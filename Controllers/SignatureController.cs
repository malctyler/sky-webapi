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

        [HttpGet("{inspectorName}")]
        public IActionResult GetSignature(string inspectorName)
        {
            try
            {
                var wwwrootPath = _environment.WebRootPath ?? _environment.ContentRootPath;
                var signaturePath = Path.Combine(wwwrootPath, "SecureFiles", "Signatures", $"{inspectorName.ToLower().Replace(" ", "_")}.jpg");
                
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
    }
}
