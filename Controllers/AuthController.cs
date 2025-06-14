using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using sky_webapi.Data.Entities;
using sky_webapi.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace sky_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly ILogger<AuthController> _logger;

        public AuthController(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration configuration,
            ILogger<AuthController> logger)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _logger = logger;
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
                }

                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    IsCustomer = model.IsCustomer,
                    CustomerId = model.CustomerId
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
                }

                await _userManager.AddClaimsAsync(user, claims);

                _logger.LogInformation("User registered successfully: {Email}", model.Email);
                return Ok(new { Message = "User created successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during user registration for {Email}", model.Email);
                return StatusCode(500, new { Message = "An error occurred during registration. Please try again later." });
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    _logger.LogWarning("Login attempt with non-existent email: {Email}", model.Email);
                    return Unauthorized(new { Message = "Invalid email or password." });
                }

                if (!await _userManager.CheckPasswordAsync(user, model.Password))
                {
                    _logger.LogWarning("Login attempt with incorrect password for user: {Email}", model.Email);
                    return Unauthorized(new { Message = "Invalid email or password." });
                }

                var userRoles = await _userManager.GetRolesAsync(user);
                var userClaims = await _userManager.GetClaimsAsync(user);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id),
                    new Claim(ClaimTypes.Email, user.Email ?? string.Empty),
                    new Claim(ClaimTypes.GivenName, user.FirstName ?? string.Empty),
                    new Claim(ClaimTypes.Surname, user.LastName ?? string.Empty),
                    new Claim("EmailConfirmed", user.EmailConfirmed.ToString()),
                    new Claim("IsCustomer", user.IsCustomer.ToString())
                };

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

                // Generate JWT token
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(claims),
                    Expires = DateTime.UtcNow.AddMinutes(
                        Convert.ToDouble(_configuration["JwtSettings:DurationInMinutes"])),
                    Issuer = _configuration["JwtSettings:Issuer"],
                    Audience = _configuration["JwtSettings:Audience"],
                    SigningCredentials = creds
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                var tokenString = tokenHandler.WriteToken(token);

                // Get the origin from the request
                var origin = Request.Headers["Origin"].ToString();
                _logger.LogInformation("Request origin: {Origin}", origin);

                var cookieOptions = new CookieOptions
                {
                    HttpOnly = true,
                    Path = "/",
                    Expires = DateTime.UtcNow.AddMinutes(
                        Convert.ToDouble(_configuration["JwtSettings:DurationInMinutes"]))
                };

                // Configure cookie options based on the environment and origin
                if (origin.Contains("localhost"))
                {
                    cookieOptions.Secure = false;
                    cookieOptions.SameSite = SameSiteMode.None;
                    // Don't set domain for localhost
                }
                else
                {
                    cookieOptions.Secure = true;
                    cookieOptions.SameSite = SameSiteMode.None;
                    cookieOptions.Domain = ".azurewebsites.net"; // Note the leading dot
                }

                _logger.LogInformation("Setting cookie with options: HttpOnly={HttpOnly}, Secure={Secure}, SameSite={SameSite}, Domain={Domain}",
                    cookieOptions.HttpOnly, cookieOptions.Secure, cookieOptions.SameSite, 
                    cookieOptions.Domain ?? "not set");

                Response.Cookies.Append("jwt", tokenString, cookieOptions);

                _logger.LogInformation("User logged in successfully: {Email}", model.Email);

                return Ok(new AuthResponseDto
                {
                    Id = user.Id,
                    Email = user.Email ?? string.Empty,
                    FirstName = user.FirstName ?? string.Empty,
                    LastName = user.LastName ?? string.Empty,
                    Roles = userRoles.ToList(),
                    IsCustomer = user.IsCustomer,
                    EmailConfirmed = user.EmailConfirmed,
                    CustomerId = user.CustomerId,
                    Token = tokenString // Include token in response for debugging
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during login for {Email}", model.Email);
                return StatusCode(500, new { Message = "An error occurred during login. Please try again later." });
            }
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
                }

                var changePasswordResult = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                if (!changePasswordResult.Succeeded)
                {
                    var errors = changePasswordResult.Errors.Select(e => e.Description);
                    _logger.LogWarning("Password change failed for user {Email}. Errors: {Errors}", 
                        email, string.Join(", ", errors));
                    return BadRequest(new { Errors = errors });
                }

                _logger.LogInformation("Password changed successfully for user: {Email}", email);
                return Ok(new { Message = "Password changed successfully." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during password change");
                return StatusCode(500, new { Message = "An error occurred while changing the password." });
            }
        }        [HttpPost("logout")]
        [Authorize]
        public IActionResult Logout()
        {
            var email = User.FindFirst(ClaimTypes.Email)?.Value;
            if (!string.IsNullOrEmpty(email))
            {
                _logger.LogInformation("User logged out: {Email}", email);
            }

            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Secure = Request.Scheme == "https",
                SameSite = SameSiteMode.Lax,
                Path = "/"
            };

            if (!Request.Host.Host.Contains("localhost"))
            {
                cookieOptions.Domain = "azurewebsites.net";
            }

            Response.Cookies.Delete("jwt", cookieOptions);
            return Ok(new { Message = "Logged out successfully" });
        }

        [HttpGet("validate")]
        [Authorize]
        public IActionResult ValidateToken()
        {
            return Ok(new { valid = true });
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
                            existingClaim.Value == c.Value)));

                    var key = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(_configuration["JwtSettings:SecretKey"] ?? 
                            throw new InvalidOperationException("JWT SecretKey is not configured")));
                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(
                        issuer: _configuration["JwtSettings:Issuer"],
                        audience: _configuration["JwtSettings:Audience"],
                        claims: claims,
                        expires: DateTime.Now.AddMinutes(
                            Convert.ToDouble(_configuration["JwtSettings:DurationInMinutes"])),
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
        }

        [HttpPost("dev/reset-admin")]
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

            _logger.LogInformation("Admin password reset successfully");
            return Ok(new { Message = "Admin password reset to: " + newPassword });
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
                var email = User.FindFirst(ClaimTypes.Email)?.Value;
                if (string.IsNullOrEmpty(email))
                {
                    return Unauthorized();
                }

                var user = await _userManager.FindByEmailAsync(email);
                if (user == null)
                {
                    return Unauthorized();
                }                var userRoles = await _userManager.GetRolesAsync(user);
                  return Ok(new AuthResponseDto
                {
                    Id = user.Id,
                    Email = user.Email ?? string.Empty,
                    FirstName = user.FirstName ?? string.Empty,
                    LastName = user.LastName ?? string.Empty,
                    Roles = userRoles.ToList(),
                    IsCustomer = user.IsCustomer,
                    EmailConfirmed = user.EmailConfirmed,
                    CustomerId = user.CustomerId,
                    Token = jwtToken // Include the token in the response for debugging
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
        {
            var jwtCookie = Request.Cookies["jwt"];
            if (string.IsNullOrEmpty(jwtCookie))
            {
                return BadRequest(new { Message = "No JWT cookie found" });
            }

            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(jwtCookie) as JwtSecurityToken;
                
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
    }
}