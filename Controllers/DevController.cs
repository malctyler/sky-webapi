using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sky_webapi.Data;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "Admin")] // Restored for security
    public class DevController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;
        private readonly ILogger<DevController> _logger;

        public DevController(AppDbContext context, IConfiguration configuration, IWebHostEnvironment environment, ILogger<DevController> logger)
        {
            _context = context;
            _configuration = configuration;
            _environment = environment;
            _logger = logger;
        }

        [HttpPost("update-postcodes")]
        public IActionResult UpdatePostcodes()
        {
            if (!_environment.IsDevelopment())
            {
                return NotFound();
            }

            DatabaseSeeder.UpdateCustomerPostcodes(_context);
            return Ok(new { message = "Customer postcodes updated successfully" });
        }

        [HttpPost("clear-entity-data")]
        [Authorize(Roles = "Admin")] // Require admin authorization
        public async Task<IActionResult> ClearEntityData()
        {
            if (!_environment.IsDevelopment())
            {
                return NotFound();
            }

            try
            {
                await DatabaseSeeder.ClearCustomEntityData(_context);
                return Ok(new { message = "All custom entity data cleared successfully. ASP.NET Identity tables preserved." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = "Failed to clear data", details = ex.Message });
            }
        }

        [HttpGet("email-config-status")]
        [Authorize(Roles = "Admin")]
        public IActionResult CheckEmailConfig()
        {
            try
            {
                var emailSettings = _configuration.GetSection("EmailSettings");
                
                var configStatus = new
                {
                    SmtpServerConfigured = !string.IsNullOrEmpty(emailSettings["SmtpServer"]),
                    SmtpServer = !string.IsNullOrEmpty(emailSettings["SmtpServer"]) ? emailSettings["SmtpServer"] : "Not configured",
                    SmtpPortConfigured = !string.IsNullOrEmpty(emailSettings["SmtpPort"]),
                    SmtpPort = emailSettings["SmtpPort"] ?? "Not configured",
                    EnableSslConfigured = !string.IsNullOrEmpty(emailSettings["EnableSsl"]),
                    EnableSsl = emailSettings["EnableSsl"] ?? "Not configured",
                    FromEmailConfigured = !string.IsNullOrEmpty(emailSettings["FromEmail"]),
                    FromEmail = !string.IsNullOrEmpty(emailSettings["FromEmail"]) ? emailSettings["FromEmail"] : "Not configured",
                    FromNameConfigured = !string.IsNullOrEmpty(emailSettings["FromName"]),
                    FromName = !string.IsNullOrEmpty(emailSettings["FromName"]) ? emailSettings["FromName"] : "Not configured",
                    SmtpUsernameConfigured = !string.IsNullOrEmpty(emailSettings["SmtpUsername"]),
                    SmtpUsername = !string.IsNullOrEmpty(emailSettings["SmtpUsername"]) ? emailSettings["SmtpUsername"] : "Not configured",
                    SmtpPasswordConfigured = !string.IsNullOrEmpty(emailSettings["SmtpPassword"]),
                    SmtpPassword = !string.IsNullOrEmpty(emailSettings["SmtpPassword"]) ? "***CONFIGURED***" : "Not configured",
                    
                    // Environment info
                    Environment = _environment.EnvironmentName,
                    
                    // Overall status
                    AllSettingsConfigured = !string.IsNullOrEmpty(emailSettings["SmtpServer"]) &&
                                          !string.IsNullOrEmpty(emailSettings["SmtpPort"]) &&
                                          !string.IsNullOrEmpty(emailSettings["EnableSsl"]) &&
                                          !string.IsNullOrEmpty(emailSettings["FromEmail"]) &&
                                          !string.IsNullOrEmpty(emailSettings["FromName"]) &&
                                          !string.IsNullOrEmpty(emailSettings["SmtpUsername"]) &&
                                          !string.IsNullOrEmpty(emailSettings["SmtpPassword"])
                };
                
                _logger.LogInformation("Email configuration check: AllConfigured={AllConfigured}", configStatus.AllSettingsConfigured);
                
                return Ok(configStatus);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error checking email configuration");
                return StatusCode(500, new { Message = "Error checking email configuration", Error = ex.Message });
            }
        }

        [HttpGet("health-check")]
        [AllowAnonymous] // Public endpoint for health checking
        public IActionResult HealthCheck()
        {
            try
            {
                var emailSettings = _configuration.GetSection("EmailSettings");
                
                var status = new
                {
                    ApplicationHealthy = true,
                    Environment = _environment.EnvironmentName,
                    Timestamp = DateTime.UtcNow,
                    EmailServiceConfigured = !string.IsNullOrEmpty(emailSettings["SmtpServer"]) &&
                                           !string.IsNullOrEmpty(emailSettings["SmtpPort"]) &&
                                           !string.IsNullOrEmpty(emailSettings["FromEmail"]) &&
                                           !string.IsNullOrEmpty(emailSettings["SmtpUsername"]) &&
                                           !string.IsNullOrEmpty(emailSettings["SmtpPassword"]),
                    
                    ConfigurationSummary = new
                    {
                        SmtpServerSet = !string.IsNullOrEmpty(emailSettings["SmtpServer"]),
                        SmtpPortSet = !string.IsNullOrEmpty(emailSettings["SmtpPort"]),
                        FromEmailSet = !string.IsNullOrEmpty(emailSettings["FromEmail"]),
                        SmtpUsernameSet = !string.IsNullOrEmpty(emailSettings["SmtpUsername"]),
                        SmtpPasswordSet = !string.IsNullOrEmpty(emailSettings["SmtpPassword"])
                    }
                };
                
                _logger.LogInformation("Health check performed. Email configured: {EmailConfigured}", status.EmailServiceConfigured);
                
                return Ok(status);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during health check");
                return StatusCode(500, new { 
                    ApplicationHealthy = false, 
                    Error = "Health check failed",
                    Timestamp = DateTime.UtcNow 
                });
            }
        }
    }
}
