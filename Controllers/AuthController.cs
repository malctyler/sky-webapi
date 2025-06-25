using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using sky_webapi.Data.Entities;
using sky_webapi.DTOs;
using Microsoft.AspNetCore.Authorization;
using sky_webapi.Services;

namespace sky_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly ILogger<AuthController> _logger;
        private readonly IPasswordSecurityService _passwordSecurity;
        private readonly IEmailService _emailService;

        public AuthController(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration configuration,
            ILogger<AuthController> logger,
            IPasswordSecurityService passwordSecurity,
            IEmailService emailService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _logger = logger;
            _passwordSecurity = passwordSecurity;
            _emailService = emailService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto model)
        {
            try
            {
                var userExists = await _userManager.FindByEmailAsync(model.Email);
                if (userExists != null)
                {
                    _logger.LogWarning("Registration attempt with existing email: {Email}", model.Email);
                    return BadRequest(new { Message = "User with this email already exists." });
                }                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    IsCustomer = model.IsCustomer,
                    CustomerId = model.CustomerId,
                    EmailConfirmed = false // Require admin confirmation
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (!result.Succeeded)
                {
                    var errors = result.Errors.Select(e => e.Description);
                    _logger.LogError("User registration failed for {Email}. Errors: {Errors}", 
                        model.Email, string.Join(", ", errors));
                    return BadRequest(new { Errors = errors });
                }

                // Assign role based on whether the user is a customer or staff
                var roleName = model.IsCustomer ? "Customer" : "Staff";
                
                // Create role if it doesn't exist
                if (!await _roleManager.RoleExistsAsync(roleName))
                {
                    var roleResult = await _roleManager.CreateAsync(new IdentityRole(roleName));
                    if (!roleResult.Succeeded)
                    {
                        _logger.LogError("Role creation failed for {Role}. Errors: {Errors}", 
                            roleName, string.Join(", ", roleResult.Errors.Select(e => e.Description)));
                        // Continue anyway as the role might have been created by another concurrent request
                    }
                }

                await _userManager.AddToRoleAsync(user, roleName);

                // Add claims
                var claims = new List<Claim>
                {
                    new Claim("IsCustomer", model.IsCustomer.ToString())
                };

                if (model.CustomerId.HasValue)
                {
                    claims.Add(new Claim("CustomerId", model.CustomerId.Value.ToString()));
                }                await _userManager.AddClaimsAsync(user, claims);

                // Store transmission hash for secure login compatibility
                var transmissionHash = _passwordSecurity.HashPasswordForTransmission(model.Password, user.Email!);
                await _userManager.AddClaimAsync(user, new Claim("TransmissionPasswordHash", transmissionHash));

                _logger.LogInformation("User registered successfully with secure login compatibility: {Email}", model.Email);
                return Ok(new { Message = "User created successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during user registration for {Email}", model.Email);
                return StatusCode(500, new { Message = "An error occurred during registration. Please try again later." });
            }
        }        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            try
            {
                // Handle preflight request
                if (Request.Method == "OPTIONS")
                {
                    Response.Headers.Append("Access-Control-Allow-Credentials", "true");
                    if (Request.Headers.TryGetValue("Origin", out var preflightOrigin))
                    {
                        Response.Headers.Append("Access-Control-Allow-Origin", preflightOrigin.ToString());
                    }
                    return Ok();
                }                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    _logger.LogWarning("Login attempt with non-existent email: {Email}", model.Email);
                    return Unauthorized(new { Message = "Invalid email or password." });
                }

                // Check if email is confirmed
                if (!user.EmailConfirmed)
                {
                    _logger.LogWarning("Login attempt with unconfirmed email: {Email}", model.Email);
                    return Unauthorized(new { Message = "Please contact an administrator to confirm your account before logging in." });
                }

                if (!await _userManager.CheckPasswordAsync(user, model.Password))
                {
                    _logger.LogWarning("Login attempt with incorrect password for user: {Email}", model.Email);
                    return Unauthorized(new { Message = "Invalid email or password." });
                }

                // MIGRATION: Automatically migrate users to secure login compatibility
                // Check if user has transmission hash stored
                var existingClaims = await _userManager.GetClaimsAsync(user);
                var hasTransmissionHash = existingClaims.Any(c => c.Type == "TransmissionPasswordHash");
                
                if (!hasTransmissionHash)
                {
                    try
                    {
                        // Generate and store transmission hash for future secure logins
                        var transmissionHash = _passwordSecurity.HashPasswordForTransmission(model.Password, user.Email!);
                        await _userManager.AddClaimAsync(user, new System.Security.Claims.Claim("TransmissionPasswordHash", transmissionHash));
                        _logger.LogInformation("Auto-migrated user {Email} for secure login compatibility", model.Email);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogWarning(ex, "Failed to auto-migrate user {Email} for secure login", model.Email);
                        // Continue with normal login - migration is optional
                    }
                }                var userRoles = await _userManager.GetRolesAsync(user);
                var userClaims = await _userManager.GetClaimsAsync(user);

                // Generate unique token ID for revocation tracking
                var tokenId = Guid.NewGuid().ToString();

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id),
                    new Claim(ClaimTypes.Email, user.Email ?? string.Empty),
                    new Claim(ClaimTypes.GivenName, user.FirstName ?? string.Empty),
                    new Claim(ClaimTypes.Surname, user.LastName ?? string.Empty),
                    new Claim("EmailConfirmed", user.EmailConfirmed.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti, tokenId), // Add token ID for revocation
                    new Claim(JwtRegisteredClaimNames.Sub, user.Id),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64)
                    // IsCustomer will come from userClaims to avoid duplication
                };
                
                if (user.CustomerId.HasValue)
                {
                    claims.Add(new Claim("CustomerId", user.CustomerId.Value.ToString()));
                }

                foreach (var role in userRoles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }

                claims.AddRange(userClaims.Where(c => 
                    !claims.Any(existingClaim => 
                        existingClaim.Type == c.Type && 
                        existingClaim.Value == c.Value)));

                var key = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(_configuration["JwtSettings:SecretKey"] ?? 
                        throw new InvalidOperationException("JWT SecretKey is not configured")));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);                // Calculate token expiration time (default to 60 minutes if not configured)
                var tokenDurationMinutes = _configuration["JwtSettings:DurationInMinutes"] != null
                    ? Convert.ToDouble(_configuration["JwtSettings:DurationInMinutes"])
                    : 60.0;
                  var currentUtc = DateTime.UtcNow;
                _logger.LogInformation("DEBUG - Current UTC time: {CurrentUtc}", currentUtc.ToString("O"));
                _logger.LogInformation("DEBUG - Current UTC time (Ticks): {Ticks}", currentUtc.Ticks);
                _logger.LogInformation("DEBUG - Current UTC time (Unix): {Unix}", ((DateTimeOffset)currentUtc).ToUnixTimeSeconds());
                _logger.LogInformation("Token duration minutes: {TokenDurationMinutes}", tokenDurationMinutes);
                _logger.LogInformation("JWT Issuer: {Issuer}", _configuration["JwtSettings:Issuer"]);
                _logger.LogInformation("JWT Audience: {Audience}", _configuration["JwtSettings:Audience"]);
                
                var tokenExpiration = currentUtc.AddMinutes(tokenDurationMinutes);
                _logger.LogInformation("DEBUG - Token expiration: {TokenExpiration}", tokenExpiration.ToString("O"));
                _logger.LogInformation("DEBUG - Token expiration (Ticks): {Ticks}", tokenExpiration.Ticks);
                _logger.LogInformation("DEBUG - Token expiration (Unix): {Unix}", ((DateTimeOffset)tokenExpiration).ToUnixTimeSeconds());

                // Generate JWT token
                var tokenHandler = new JwtSecurityTokenHandler();                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(claims),
                    NotBefore = currentUtc,
                    Expires = tokenExpiration,
                    Issuer = _configuration["JwtSettings:Issuer"],
                    Audience = _configuration["JwtSettings:Audience"],
                    SigningCredentials = creds
                };                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var generatedToken = tokenHandler.WriteToken(securityToken);
                
                // Verify the token's expiration time
                var jwt = new JwtSecurityToken(generatedToken);
                _logger.LogInformation("DEBUG - JWT nbf (Not Before): {NotBefore}", jwt.ValidFrom.ToString("O"));
                _logger.LogInformation("DEBUG - JWT exp (Expiration): {Expiration}", jwt.ValidTo.ToString("O"));
                _logger.LogInformation("DEBUG - JWT exp (Unix): {Unix}", ((DateTimeOffset)jwt.ValidTo).ToUnixTimeSeconds());
                
                // Double-check: manually decode the token to see the exp claim
                var payload = jwt.Payload;
                if (payload.ContainsKey("exp"))
                {
                    var expClaim = payload["exp"];
                    _logger.LogInformation("DEBUG - JWT exp claim (raw): {ExpClaim}", expClaim);
                    
                    // Convert Unix timestamp back to DateTime
                    var expUnix = Convert.ToInt64(expClaim);
                    var expDateTime = DateTimeOffset.FromUnixTimeSeconds(expUnix).DateTime;
                    _logger.LogInformation("DEBUG - JWT exp converted back: {ExpDateTime}", expDateTime.ToString("O"));
                }// Get the origin from the request
                var origin = Request.Headers["Origin"].ToString();
                var isLocalhost = origin.Contains("localhost");
                var isAzureStaticWebApp = origin.Contains("azurestaticapps.net") || origin.Contains("wonderfulbay-");
                
                _logger.LogInformation("Origin: {Origin}, IsLocalhost: {IsLocalhost}, IsAzureStaticWebApp: {IsAzureStaticWebApp}", 
                    origin, isLocalhost, isAzureStaticWebApp);

                // Set CORS headers explicitly
                Response.Headers.Append("Access-Control-Allow-Credentials", "true");
                if (!string.IsNullOrEmpty(origin))
                {
                    Response.Headers.Append("Access-Control-Allow-Origin", origin);
                }                // For Azure Static Web Apps, we'll rely on Authorization header instead of cookies
                // due to cross-domain limitations. Still set a cookie for same-domain scenarios.
                // IMPORTANT: Use DateTimeOffset to ensure proper UTC handling for cookie expiration
                var cookieExpirationUtc = new DateTimeOffset(tokenExpiration, TimeSpan.Zero);
                
                var cookieOptions = new CookieOptions
                {
                    HttpOnly = false, // Must be false for cross-domain Azure Static Web Apps
                    Path = "/",
                    Secure = true,
                    SameSite = SameSiteMode.None, // Required for cross-site requests
                    Expires = cookieExpirationUtc // Use DateTimeOffset to ensure UTC
                };

                _logger.LogInformation("DEBUG - Token expiration (DateTime): {TokenExpiration}", tokenExpiration.ToString("O"));
                _logger.LogInformation("DEBUG - Cookie expiration (DateTimeOffset): {CookieExpiration}", cookieExpirationUtc.ToString("O"));
                _logger.LogInformation("DEBUG - About to set cookie with token length: {TokenLength}", generatedToken.Length);                _logger.LogInformation(
                    "Setting cookie with options: HttpOnly={HttpOnly}, Secure={Secure}, SameSite={SameSite}, Path={Path}, TokenExpires={TokenExpires}, CookieExpires={CookieExpires}",
                    cookieOptions.HttpOnly, cookieOptions.Secure, cookieOptions.SameSite, cookieOptions.Path, 
                    tokenExpiration.ToString("O"), cookieExpirationUtc.ToString("O"));// Set cookie (works for same-domain, fallback for cross-domain)
                Response.Cookies.Append("auth_token", generatedToken, cookieOptions);
                
                // Debug: Log the actual Set-Cookie header that will be sent to the browser
                var cookieHeaderValue = $"auth_token={generatedToken}; expires={cookieOptions.Expires?.ToString("R")}; path={cookieOptions.Path}; secure; samesite=none";
                _logger.LogInformation("DEBUG - Set-Cookie header value: {SetCookieHeader}", cookieHeaderValue);
                  // Also log if there are any existing Set-Cookie headers
                if (Response.Headers.ContainsKey("Set-Cookie"))
                {
                    var existingCookies = Response.Headers["Set-Cookie"];
                    _logger.LogInformation("DEBUG - Existing Set-Cookie headers: {ExistingCookies}", string.Join("; ", existingCookies.ToArray()));
                }var response = new AuthResponseDto
                {
                    Id = user.Id,
                    Email = user.Email ?? string.Empty,
                    FirstName = user.FirstName ?? string.Empty,
                    LastName = user.LastName ?? string.Empty,
                    Roles = userRoles.ToList(),
                    IsCustomer = user.IsCustomer,
                    EmailConfirmed = user.EmailConfirmed,
                    CustomerId = user.CustomerId,
                    Token = generatedToken // Temporarily add back for debugging
                };                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during login for {Email}", model.Email);
                return StatusCode(500, new { Message = "An error occurred during login. Please try again later." });
            }
        }        [HttpPost("secure-login")]
        public async Task<IActionResult> SecureLogin([FromBody] SecureLoginDto model)
        {
            try
            {
                _logger.LogInformation("Secure login attempt for email: {Email}", model.Email);
                
                // Handle preflight request
                if (Request.Method == "OPTIONS")
                {
                    Response.Headers.Append("Access-Control-Allow-Credentials", "true");
                    if (Request.Headers.TryGetValue("Origin", out var preflightOrigin))
                    {
                        Response.Headers.Append("Access-Control-Allow-Origin", preflightOrigin.ToString());
                    }
                    return Ok();
                }

                // Validate nonce and timestamp for replay attack prevention
                if (!_passwordSecurity.ValidateNonce(model.Nonce, model.Timestamp))
                {
                    _logger.LogWarning("Secure login attempt with invalid nonce/timestamp for email: {Email}", model.Email);
                    return BadRequest(new { Message = "Invalid request. Please try again." });
                }                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    _logger.LogWarning("Secure login attempt with non-existent email: {Email}", model.Email);
                    return Unauthorized(new { Message = "Invalid email or password." });
                }

                // Check if email is confirmed
                if (!user.EmailConfirmed)
                {
                    _logger.LogWarning("Secure login attempt with unconfirmed email: {Email}", model.Email);
                    return Unauthorized(new { Message = "Please contact an administrator to confirm your account before logging in." });
                }

                // Verify the secure password hash
                var isPasswordValid = await _passwordSecurity.VerifySecurePassword(user.Email!, model.PasswordHash, _userManager);
                if (isPasswordValid)
                {
                    // Continue with the same JWT generation logic as regular login
                    return await GenerateTokenResponse(user);
                }
                else
                {
                    _logger.LogWarning("Secure login attempt with incorrect password for user: {Email}", model.Email);
                    return Unauthorized(new { Message = "Invalid email or password." });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during secure login for {Email}", model.Email);
                return StatusCode(500, new { Message = "An error occurred during login. Please try again later." });
            }
        }        private async Task<IActionResult> GenerateTokenResponse(ApplicationUser user)
        {
            // Extract the JWT generation logic from the regular login method
            var userRoles = await _userManager.GetRolesAsync(user);
            var userClaims = await _userManager.GetClaimsAsync(user);

            // Generate unique token ID for revocation tracking
            var tokenId = Guid.NewGuid().ToString();

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Email, user.Email ?? string.Empty),
                new Claim(ClaimTypes.GivenName, user.FirstName ?? string.Empty),
                new Claim(ClaimTypes.Surname, user.LastName ?? string.Empty),
                new Claim("EmailConfirmed", user.EmailConfirmed.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, tokenId), // Add token ID for revocation
                new Claim(JwtRegisteredClaimNames.Sub, user.Id),
                new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64)
            };
            
            if (user.CustomerId.HasValue)
            {
                claims.Add(new Claim("CustomerId", user.CustomerId.Value.ToString()));
            }

            foreach (var role in userRoles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            claims.AddRange(userClaims.Where(c => 
                !claims.Any(existingClaim => 
                    existingClaim.Type == c.Type && 
                    existingClaim.Value == c.Value)));

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration["JwtSettings:SecretKey"] ?? 
                    throw new InvalidOperationException("JWT SecretKey is not configured")));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var tokenDurationMinutes = _configuration["JwtSettings:DurationInMinutes"] != null
                ? Convert.ToDouble(_configuration["JwtSettings:DurationInMinutes"])
                : 60.0;
                
            var currentUtc = DateTime.UtcNow;
            var tokenExpiration = currentUtc.AddMinutes(tokenDurationMinutes);

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                NotBefore = currentUtc,
                Expires = tokenExpiration,
                Issuer = _configuration["JwtSettings:Issuer"],
                Audience = _configuration["JwtSettings:Audience"],
                SigningCredentials = creds
            };

            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var generatedToken = tokenHandler.WriteToken(securityToken);

            // Set CORS headers
            var origin = Request.Headers["Origin"].ToString();
            Response.Headers.Append("Access-Control-Allow-Credentials", "true");
            if (!string.IsNullOrEmpty(origin))
            {
                Response.Headers.Append("Access-Control-Allow-Origin", origin);
            }

            // Set cookie with secure options
            var cookieExpirationUtc = new DateTimeOffset(tokenExpiration, TimeSpan.Zero);
            var cookieOptions = new CookieOptions
            {
                HttpOnly = false,
                Path = "/",
                Secure = true,
                SameSite = SameSiteMode.None,
                Expires = cookieExpirationUtc
            };

            Response.Cookies.Append("auth_token", generatedToken, cookieOptions);

            var response = new AuthResponseDto
            {
                Id = user.Id,
                Email = user.Email ?? string.Empty,
                FirstName = user.FirstName ?? string.Empty,
                LastName = user.LastName ?? string.Empty,
                Roles = userRoles.ToList(),
                IsCustomer = user.IsCustomer,
                EmailConfirmed = user.EmailConfirmed,
                CustomerId = user.CustomerId,
                Token = generatedToken
            };

            _logger.LogInformation("Secure login successful for user: {Email}", user.Email);
            return Ok(response);
        }

        [HttpPost("change-password")]
        [Authorize]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto model)
        {
            try
            {
                if (model.NewPassword != model.ConfirmNewPassword)
                {
                    return BadRequest(new { Message = "New password and confirmation password do not match." });
                }

                var email = User.FindFirst(ClaimTypes.Email)?.Value;
                if (string.IsNullOrEmpty(email))
                {
                    return BadRequest(new { Message = "Unable to identify user." });
                }

                var user = await _userManager.FindByEmailAsync(email);
                if (user == null)
                {
                    return BadRequest(new { Message = "User not found." });
                }                var changePasswordResult = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                if (!changePasswordResult.Succeeded)
                {
                    var errors = changePasswordResult.Errors.Select(e => e.Description);
                    _logger.LogWarning("Password change failed for user {Email}. Errors: {Errors}", 
                        email, string.Join(", ", errors));
                    return BadRequest(new { Errors = errors });
                }

                // Update transmission hash for secure login compatibility
                var transmissionHash = _passwordSecurity.HashPasswordForTransmission(model.NewPassword, user.Email!);
                
                // Remove existing transmission hash claim if it exists
                var existingClaims = await _userManager.GetClaimsAsync(user);
                var existingHashClaim = existingClaims.FirstOrDefault(c => c.Type == "TransmissionPasswordHash");
                if (existingHashClaim != null)
                {
                    await _userManager.RemoveClaimAsync(user, existingHashClaim);
                }
                
                // Add new transmission hash claim
                await _userManager.AddClaimAsync(user, new Claim("TransmissionPasswordHash", transmissionHash));

                _logger.LogInformation("Password changed successfully with secure login compatibility for user: {Email}", email);
                return Ok(new { Message = "Password changed successfully." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during password change");
                return StatusCode(500, new { Message = "An error occurred while changing the password." });
            }
        }        [HttpPost("logout")]
        [Authorize]
        public async Task<IActionResult> Logout([FromServices] ITokenRevocationService tokenRevocationService)
        {
            var email = User.FindFirst(ClaimTypes.Email)?.Value;
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var tokenId = User.FindFirst(JwtRegisteredClaimNames.Jti)?.Value;

            if (!string.IsNullOrEmpty(email))
            {
                _logger.LogInformation("User logout attempt: {Email}", email);
            }

            // Revoke the current token
            if (!string.IsNullOrEmpty(tokenId) && !string.IsNullOrEmpty(userId))
            {
                try
                {
                    var clientIp = HttpContext.Connection.RemoteIpAddress?.ToString();
                    await tokenRevocationService.RevokeTokenAsync(tokenId, userId, "logout", clientIp);
                    _logger.LogInformation("Token {TokenId} revoked during logout for user {Email}", tokenId, email);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Failed to revoke token during logout for user {Email}", email);
                    // Continue with logout even if token revocation fails
                }
            }

            var origin = Request.Headers["Origin"].ToString();
            var isLocalhost = origin.Contains("localhost");
            var isSecure = Request.IsHttps || !isLocalhost;            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Path = "/",
                Secure = true,
                SameSite = SameSiteMode.None,
                // Don't set Domain for cross-domain cookies with Azure Static Web Apps
            };

            _logger.LogInformation("Clearing cookie with options: HttpOnly={HttpOnly}, Secure={Secure}, SameSite={SameSite}, Path={Path}",
                cookieOptions.HttpOnly, cookieOptions.Secure, cookieOptions.SameSite, cookieOptions.Path);

            Response.Cookies.Delete("auth_token", cookieOptions);
            
            if (!string.IsNullOrEmpty(email))
            {
                _logger.LogInformation("User logged out successfully: {Email}", email);
            }
            
            return Ok(new { Message = "Logged out successfully" });
        }[HttpGet("validate")]
        [Authorize]
        public async Task<IActionResult> ValidateToken()
        {
            try
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userId))
                {
                    _logger.LogWarning("Token validation failed: No user ID claim found");
                    return Unauthorized(new { Message = "Invalid token" });
                }                var user = await _userManager.FindByIdAsync(userId);
                if (user == null)
                {
                    _logger.LogWarning("Token validation failed: User not found for ID: {UserId}", userId);
                    return Unauthorized(new { Message = "Invalid token" });
                }

                var roles = await _userManager.GetRolesAsync(user);                _logger.LogInformation("Token validated successfully for user ID: {UserId}", userId);
                
                return Ok(new { 
                    valid = true,
                    userId = user.Id,
                    email = user.Email ?? string.Empty,
                    firstName = user.FirstName ?? string.Empty,
                    lastName = user.LastName ?? string.Empty,
                    roles = roles.ToList(),
                    isCustomer = user.IsCustomer,
                    emailConfirmed = user.EmailConfirmed,
                    customerId = user.CustomerId
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error validating token");
                return StatusCode(500, new { Message = "An error occurred while validating the token" });
            }
        }

        [HttpGet("check-email-confirmation/{email}")]
        public async Task<IActionResult> CheckEmailConfirmation(string email)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(email);
                if (user == null)
                {
                    return NotFound(new { Message = "User not found" });
                }

                if (user.EmailConfirmed)
                {
                    // If email is confirmed, generate a new token with updated status
                    var userRoles = await _userManager.GetRolesAsync(user);
                    var userClaims = await _userManager.GetClaimsAsync(user);

                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.Id),
                        new Claim(ClaimTypes.Email, user.Email ?? string.Empty),
                        new Claim("EmailConfirmed", user.EmailConfirmed.ToString()),
                        new Claim("IsCustomer", user.IsCustomer.ToString())
                    };

                    if (user.CustomerId.HasValue)
                    {
                        claims.Add(new Claim("CustomerId", user.CustomerId.Value.ToString()));
                    }

                    // Add roles as claims
                    foreach (var role in userRoles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role));
                    }

                    claims.AddRange(userClaims.Where(c => 
                        !claims.Any(existingClaim => 
                            existingClaim.Type == c.Type && 
                            existingClaim.Value == c.Value)));                    var key = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(_configuration["JwtSettings:SecretKey"] ?? 
                            throw new InvalidOperationException("JWT SecretKey is not configured")));
                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var currentUtc = DateTime.UtcNow;
                    var tokenDurationMinutes = Convert.ToDouble(_configuration["JwtSettings:DurationInMinutes"]);
                    var tokenExpiration = currentUtc.AddMinutes(tokenDurationMinutes);
                    
                    _logger.LogInformation("CheckEmailConfirmation - Current UTC: {CurrentUtc}, Token Expiration: {TokenExpiration}", 
                        currentUtc.ToString("O"), tokenExpiration.ToString("O"));

                    var token = new JwtSecurityToken(
                        issuer: _configuration["JwtSettings:Issuer"],
                        audience: _configuration["JwtSettings:Audience"],
                        claims: claims,
                        notBefore: currentUtc,
                        expires: tokenExpiration,
                        signingCredentials: creds
                    );

                    return Ok(new AuthResponseDto
                    {
                        Token = new JwtSecurityTokenHandler().WriteToken(token),
                        Email = user.Email ?? string.Empty,
                        IsCustomer = user.IsCustomer,
                        EmailConfirmed = true
                    });
                }

                return Ok(new { EmailConfirmed = false });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error checking email confirmation status for {Email}", email);
                return StatusCode(500, new { Message = "An error occurred while checking email confirmation status." });
            }
        }        [HttpPost("dev/reset-admin")]
        public async Task<IActionResult> ResetAdminPassword()
        {
            #if DEBUG
            var admin = await _userManager.FindByEmailAsync("admin@example.com");
            if (admin == null)
                return NotFound(new { Message = "Admin user not found" });

            string newPassword = "Admin123!";
            string resetToken = await _userManager.GeneratePasswordResetTokenAsync(admin);
            var result = await _userManager.ResetPasswordAsync(admin, resetToken, newPassword);

            if (!result.Succeeded)
                return BadRequest(new { Errors = result.Errors });

            // Store the transmission hash for secure login compatibility
            var transmissionHash = _passwordSecurity.HashPasswordForTransmission(newPassword, admin.Email!);
            
            // Remove existing transmission hash claim if it exists
            var existingClaims = await _userManager.GetClaimsAsync(admin);
            var existingHashClaim = existingClaims.FirstOrDefault(c => c.Type == "TransmissionPasswordHash");
            if (existingHashClaim != null)
            {
                await _userManager.RemoveClaimAsync(admin, existingHashClaim);
            }
            
            // Add new transmission hash claim
            await _userManager.AddClaimAsync(admin, new System.Security.Claims.Claim("TransmissionPasswordHash", transmissionHash));

            _logger.LogInformation("Admin password reset successfully with secure login compatibility");
            return Ok(new { 
                Message = "Admin password reset to: " + newPassword,
                SecureLoginReady = true,
                Note = "Password is now compatible with secure login endpoint"            });
            #else
            return NotFound();
            #endif
        }

        [HttpPost("dev/reset-user")]
        public async Task<IActionResult> ResetUserPassword([FromBody] ResetUserPasswordDto dto)
        {
            #if DEBUG
            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user == null)
                return NotFound(new { Message = "User not found" });

            string resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, resetToken, dto.NewPassword);

            if (!result.Succeeded)
                return BadRequest(new { Errors = result.Errors });

            // Store the transmission hash for secure login compatibility
            var transmissionHash = _passwordSecurity.HashPasswordForTransmission(dto.NewPassword, user.Email!);
            
            // Remove existing transmission hash claim if it exists
            var existingClaims = await _userManager.GetClaimsAsync(user);
            var existingHashClaim = existingClaims.FirstOrDefault(c => c.Type == "TransmissionPasswordHash");
            if (existingHashClaim != null)
            {
                await _userManager.RemoveClaimAsync(user, existingHashClaim);
            }
            
            // Add new transmission hash claim
            await _userManager.AddClaimAsync(user, new System.Security.Claims.Claim("TransmissionPasswordHash", transmissionHash));

            _logger.LogInformation("User password reset successfully with secure login compatibility for {Email}", dto.Email);
            return Ok(new { 
                Message = $"User {dto.Email} password reset to: {dto.NewPassword}",
                SecureLoginReady = true,
                Note = "Password is now compatible with secure login endpoint"            });
            #else
            return NotFound();
            #endif
        }

        [HttpPost("dev/confirm-user")]
        public async Task<IActionResult> ConfirmUserEmail([FromBody] ConfirmUserDto dto)
        {
            #if DEBUG
            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user == null)
                return NotFound(new { Message = "User not found" });

            user.EmailConfirmed = true;
            var result = await _userManager.UpdateAsync(user);

            if (!result.Succeeded)
                return BadRequest(new { Errors = result.Errors });

            _logger.LogInformation("User email confirmed successfully for {Email}", dto.Email);
            return Ok(new { 
                Message = $"User {dto.Email} email confirmed successfully",
                EmailConfirmed = true,
                Note = "User can now log in"
            });
            #else
            return NotFound();
            #endif
        }

        [HttpGet("current")]
        [Authorize]
        public async Task<ActionResult<AuthResponseDto>> GetCurrentUser()
        {
            try
            {
                _logger.LogInformation("GetCurrentUser called");
                
                // Log all cookies received
                foreach (var cookie in Request.Cookies)
                {
                    _logger.LogInformation("Cookie received: {Name} = {Value}", cookie.Key, 
                        string.IsNullOrEmpty(cookie.Value) ? "empty" : cookie.Value.Substring(0, Math.Min(20, cookie.Value.Length)) + "...");
                }
                
                var email = User.FindFirst(ClaimTypes.Email)?.Value;
                _logger.LogInformation("User email from claims: {Email}", email);
                
                if (string.IsNullOrEmpty(email))
                {
                    _logger.LogWarning("No email claim found in token");
                    return Unauthorized();
                }

                var user = await _userManager.FindByEmailAsync(email);
                if (user == null)
                {
                    _logger.LogWarning("User not found in database for email: {Email}", email);
                    return Unauthorized();
                }var userRoles = await _userManager.GetRolesAsync(user);                  return Ok(new AuthResponseDto
                {
                    Id = user.Id,
                    Email = user.Email ?? string.Empty,
                    FirstName = user.FirstName ?? string.Empty,
                    LastName = user.LastName ?? string.Empty,
                    Roles = userRoles.ToList(),
                    IsCustomer = user.IsCustomer,
                    EmailConfirmed = user.EmailConfirmed,
                    CustomerId = user.CustomerId,
                    Token = string.Empty // No need to include token in current user response
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting current user");
                return StatusCode(500, new { Message = "An error occurred while getting user information." });
            }
        }

        [HttpGet("validate-cookie")]
        public IActionResult ValidateCookie()
        {            var authCookie = Request.Cookies["auth_token"];
            if (string.IsNullOrEmpty(authCookie))
            {
                return BadRequest(new { Message = "No auth token cookie found" });
            }

            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(authCookie) as JwtSecurityToken;
                
                if (jsonToken == null) 
                    return BadRequest(new { Message = "Invalid JWT format" });

                if (jsonToken.ValidTo < DateTime.UtcNow)
                    return BadRequest(new { Message = "Token has expired" });

                return Ok(new { 
                    Message = "Valid JWT cookie",
                    ExpiresAt = jsonToken.ValidTo,
                    Claims = jsonToken.Claims.Select(c => new { c.Type, c.Value })
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error validating JWT cookie");
                return BadRequest(new { Message = "Invalid JWT token", Error = ex.Message });
            }
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDto model)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    // For security, don't reveal if the email exists or not
                    // Always return success to prevent email enumeration
                    _logger.LogWarning("Password reset attempt for non-existent email: {Email}", model.Email);
                    return Ok(new { Message = "If the email exists in our system, a password reset link has been sent." });
                }

                // Generate password reset token
                var resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
                
                // Create reset URL (should point to frontend, not backend)
                var frontendBaseUrl = _configuration["Frontend:BaseUrl"] ?? "http://localhost:3000";
                _logger.LogInformation("Frontend base URL configuration: {FrontendBaseUrl}", frontendBaseUrl);
                var resetUrl = $"{frontendBaseUrl}/reset-password?email={Uri.EscapeDataString(user.Email!)}&token={Uri.EscapeDataString(resetToken)}";
                _logger.LogInformation("Generated reset URL: {ResetUrl}", resetUrl);

                // Send email
                await _emailService.SendPasswordResetEmailAsync(user.Email!, resetToken, resetUrl);

                _logger.LogInformation("Password reset email sent to: {Email}", model.Email);
                
                return Ok(new { Message = "If the email exists in our system, a password reset link has been sent." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error sending password reset email for {Email}", model.Email);
                return StatusCode(500, new { Message = "An error occurred while processing your request." });
            }
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDto model)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    return BadRequest(new { Message = "Invalid reset request." });
                }

                // Verify the reset token
                var result = await _userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);
                
                if (result.Succeeded)
                {
                    // Update transmission hash for secure login compatibility
                    var transmissionHash = _passwordSecurity.HashPasswordForTransmission(model.NewPassword, user.Email!);
                    
                    // Remove existing transmission hash claim if it exists
                    var existingClaims = await _userManager.GetClaimsAsync(user);
                    var existingHashClaim = existingClaims.FirstOrDefault(c => c.Type == "TransmissionPasswordHash");
                    if (existingHashClaim != null)
                    {
                        await _userManager.RemoveClaimAsync(user, existingHashClaim);
                    }
                    
                    // Add new transmission hash claim
                    await _userManager.AddClaimAsync(user, new Claim("TransmissionPasswordHash", transmissionHash));

                    _logger.LogInformation("Password successfully reset for user: {Email} with secure login compatibility", model.Email);
                    return Ok(new { Message = "Password has been reset successfully." });
                }
                else
                {
                    var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                    _logger.LogWarning("Password reset failed for {Email}: {Errors}", model.Email, errors);
                    return BadRequest(new { Message = "Password reset failed.", Errors = result.Errors.Select(e => e.Description) });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error resetting password for {Email}", model.Email);
                return StatusCode(500, new { Message = "An error occurred while resetting your password." });
            }
        }
    }
}