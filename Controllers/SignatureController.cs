using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SignatureController : ControllerBase
    {
        private readonly IWebHostEnvironment _environment;
        private readonly ILogger<SignatureController> _logger;

        public SignatureController(IWebHostEnvironment environment, ILogger<SignatureController> logger)
        {
            _environment = environment;
            _logger = logger;
        }

        [HttpGet("test")]
        [AllowAnonymous]
        public IActionResult Test()
        {
            return Ok(new { message = "SignatureController is working", timestamp = DateTime.UtcNow });
        }

        [HttpGet("{inspectorName}")]
        [Authorize(Roles = "Staff,Admin")]
        public IActionResult GetSignature(string inspectorName)
        {
            try
            {
                // Debug authentication info
                _logger.LogInformation($"Signature request for {inspectorName}");
                _logger.LogInformation($"User authenticated: {User.Identity?.IsAuthenticated}");
                _logger.LogInformation($"User name: {User.Identity?.Name}");
                _logger.LogInformation($"User roles: {string.Join(", ", User.Claims.Where(c => c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role").Select(c => c.Value))}");
                _logger.LogInformation($"All user claims: {string.Join(", ", User.Claims.Select(c => $"{c.Type}={c.Value}"))}");
                
                // Use ContentRootPath instead of WebRootPath since SecureFiles is at the project root, not in wwwroot
                var contentRootPath = _environment.ContentRootPath;
                var signaturePath = Path.Combine(contentRootPath, "SecureFiles", "Signatures", $"{inspectorName.ToLower().Replace(" ", "_")}.jpg");
                
                _logger.LogInformation($"Attempting to find signature at path: {signaturePath}");
                _logger.LogInformation($"WebRootPath: {_environment.WebRootPath}");
                _logger.LogInformation($"ContentRootPath: {_environment.ContentRootPath}");

                if (!System.IO.File.Exists(signaturePath))
                {
                    _logger.LogWarning($"Signature file not found at: {signaturePath}");
                    return NotFound($"Signature not found for {inspectorName}");
                }

                var imageBytes = System.IO.File.ReadAllBytes(signaturePath);
                return File(imageBytes, "image/jpeg");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving signature for {inspectorName}", inspectorName);
                return StatusCode(500, $"Error retrieving signature: {ex.Message}");
            }
        }

        [HttpGet("debug-auth")]
        [AllowAnonymous]
        public IActionResult DebugAuth()
        {
            try
            {
                var authHeader = Request.Headers.Authorization.ToString();
                var cookieToken = Request.Cookies["auth_token"];
                
                _logger.LogInformation($"Debug Auth endpoint called");
                _logger.LogInformation($"Authorization header: {(!string.IsNullOrEmpty(authHeader) ? "Present" : "Missing")}");
                _logger.LogInformation($"Auth cookie: {(!string.IsNullOrEmpty(cookieToken) ? "Present" : "Missing")}");
                _logger.LogInformation($"User authenticated: {User.Identity?.IsAuthenticated}");
                _logger.LogInformation($"User name: {User.Identity?.Name ?? "N/A"}");
                
                if (User.Identity?.IsAuthenticated == true)
                {
                    var roles = User.Claims.Where(c => c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role").Select(c => c.Value).ToList();
                    _logger.LogInformation($"User roles: {string.Join(", ", roles)}");
                    
                    return Ok(new
                    {
                        IsAuthenticated = true,
                        UserName = User.Identity.Name,
                        Roles = roles,
                        HasStaffRole = roles.Contains("Staff"),
                        AllClaims = User.Claims.Select(c => new { c.Type, c.Value }).ToList()
                    });
                }
                else
                {
                    return Ok(new
                    {
                        IsAuthenticated = false,
                        HasAuthHeader = !string.IsNullOrEmpty(authHeader),
                        HasAuthCookie = !string.IsNullOrEmpty(cookieToken),
                        Message = "User not authenticated"
                    });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in debug auth endpoint");
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }
    }
}
