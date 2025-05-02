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
                    return Unauthorized(new { Message = "Invalid email or password" });
                }

                // Prevent login if email is not confirmed
                if (!user.EmailConfirmed)
                {
                    _logger.LogWarning("Login attempt with unconfirmed email: {Email}", model.Email);
                    return Unauthorized(new { Message = "Please confirm your email before logging in." });
                }

                var isPasswordValid = await _userManager.CheckPasswordAsync(user, model.Password);
                if (!isPasswordValid)
                {
                    _logger.LogWarning("Failed login attempt for user: {Email}", model.Email);
                    return Unauthorized(new { Message = "Invalid email or password" });
                }

                var userRoles = await _userManager.GetRolesAsync(user);
                var userClaims = await _userManager.GetClaimsAsync(user);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id),
                    new Claim(ClaimTypes.Email, user.Email ?? string.Empty),
                    new Claim("EmailConfirmed", user.EmailConfirmed.ToString())
                };

                // Add roles as claims
                foreach (var role in userRoles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }

                // Add existing claims, excluding any that we're already adding
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

                _logger.LogInformation("User logged in successfully: {Email}", model.Email);
                return Ok(new AuthResponseDto
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    Email = user.Email ?? string.Empty,
                    IsCustomer = user.IsCustomer,
                    EmailConfirmed = user.EmailConfirmed
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
        }

        [HttpPost("logout")]
        [Authorize]
        public IActionResult Logout()
        {
            // Since we're using JWT tokens, we can't invalidate the token on the server side
            // The client should remove the token from their storage
            // This endpoint is mainly for logging purposes and future extensibility
            
            var email = User.FindFirst(ClaimTypes.Email)?.Value;
            if (!string.IsNullOrEmpty(email))
            {
                _logger.LogInformation("User logged out: {Email}", email);
            }
            
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
                        new Claim("EmailConfirmed", user.EmailConfirmed.ToString())
                    };

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
    }
}