using Microsoft.AspNetCore.Mvc;
using sky_webapi.DTOs;
using sky_webapi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using sky_webapi.Data.Entities;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InspectionController : ControllerBase
    {
        private readonly IInspectionService _service;
        private readonly IEmailService _emailService;
        private readonly IPlantHoldingService _plantHoldingService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<InspectionController> _logger;

        public InspectionController(
            IInspectionService service, 
            IEmailService emailService, 
            IPlantHoldingService plantHoldingService, 
            UserManager<ApplicationUser> userManager,
            ILogger<InspectionController> logger)
        {
            _service = service;
            _emailService = emailService;
            _plantHoldingService = plantHoldingService;
            _userManager = userManager;
            _logger = logger;
        }

        [HttpGet]
        [Authorize(Roles = "Staff")]
        public async Task<ActionResult<IEnumerable<InspectionReadDto>>> GetAllInspections()
        {
            var inspections = await _service.GetAllInspectionsAsync();
            return Ok(inspections);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Staff")]
        public async Task<ActionResult<InspectionReadDto>> GetInspection(int id)
        {
            var inspection = await _service.GetInspectionByIdAsync(id);
            if (inspection == null)
            {
                return NotFound();
            }
            return Ok(inspection);
        }

        [HttpGet("plantholding/{holdingId}")]
        [Authorize(Roles = "Staff,Customer")] // Allow both Staff and Customers
        public async Task<ActionResult<IEnumerable<InspectionReadDto>>> GetByPlantHolding(int holdingId)
        {
            _logger.LogInformation("GetByPlantHolding called for holdingId: {HoldingId} by user: {User}", holdingId, User.Identity?.Name);
            
            // If user is a customer, verify they own this plant holding
            if (User.IsInRole("Customer") && !User.IsInRole("Staff"))
            {
                // Get the current user from UserManager
                var currentUser = await _userManager.GetUserAsync(User);
                if (currentUser == null)
                {
                    _logger.LogWarning("Could not find user for: {User}", User.Identity?.Name);
                    return Unauthorized("User not found");
                }

                if (!currentUser.IsCustomer || !currentUser.CustomerId.HasValue)
                {
                    _logger.LogWarning("Customer access denied - User {UserId} is not a customer or has no CustomerId", currentUser.Id);
                    return Forbid("Customer access denied");
                }

                var customerId = currentUser.CustomerId.Value;
                _logger.LogInformation("Customer access attempt - CustomerId: {CustomerId}", customerId);

                // Get the plant holding to verify ownership
                var plantHolding = await _plantHoldingService.GetPlantHoldingByIdAsync(holdingId);
                if (plantHolding == null)
                {
                    _logger.LogWarning("Plant holding {HoldingId} not found", holdingId);
                    return NotFound("Plant holding not found");
                }

                _logger.LogInformation("Ownership check - PlantHolding.CustID: {PlantCustId}, Customer.Id: {CustomerId}", plantHolding.CustID, customerId);
                
                // Verify the customer owns this plant holding
                if (plantHolding.CustID != customerId)
                {
                    _logger.LogWarning("Access denied - Customer {CustomerId} attempted to access plant holding {HoldingId} owned by {PlantCustId}", customerId, holdingId, plantHolding.CustID);
                    return Forbid("Access denied: You can only view inspections for your own plant holdings");
                }
                
                _logger.LogInformation("Access granted - Customer {CustomerId} owns plant holding {HoldingId}", customerId, holdingId);
            }

            var inspections = await _service.GetInspectionsByPlantHoldingAsync(holdingId);
            _logger.LogInformation("Returning {Count} inspections for plant holding {HoldingId}", inspections.Count(), holdingId);
            return Ok(inspections);
        }

        [HttpPost]
        [Authorize(Roles = "Staff")]
        public async Task<ActionResult<InspectionReadDto>> CreateInspection(CreateUpdateInspectionDto createDto)
        {
            var createdInspection = await _service.CreateInspectionAsync(createDto);
            return CreatedAtAction(nameof(GetInspection), new { id = createdInspection.UniqueRef }, createdInspection);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Staff")]
        public async Task<ActionResult<InspectionReadDto>> UpdateInspection(int id, CreateUpdateInspectionDto updateDto)
        {
            var updatedInspection = await _service.UpdateInspectionAsync(id, updateDto);
            return Ok(updatedInspection);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> DeleteInspection(int id)
        {
            await _service.DeleteInspectionAsync(id);
            return NoContent();
        }

        [HttpPost("{id}/email")]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> EmailCertificate(int id, IFormFile pdf)
        {
            try
            {
                _logger.LogInformation("Attempting to send certificate email for inspection {InspectionId}", id);

                var inspection = await _service.GetInspectionByIdAsync(id);
                if (inspection == null)
                {
                    _logger.LogWarning("Inspection {InspectionId} not found", id);
                    return NotFound($"Inspection with ID {id} not found");
                }

                if (pdf == null || pdf.Length == 0)
                {
                    _logger.LogWarning("No PDF file received or file is empty for inspection {InspectionId}", id);
                    return BadRequest("No PDF file received or file is empty");
                }

                // Validate PDF file type
                if (!pdf.ContentType.Equals("application/pdf", StringComparison.OrdinalIgnoreCase))
                {
                    _logger.LogWarning("Invalid file type {ContentType} for inspection {InspectionId}", pdf.ContentType, id);
                    return BadRequest("Only PDF files are allowed");
                }

                // Limit file size (e.g., 10MB)
                if (pdf.Length > 10 * 1024 * 1024)
                {
                    _logger.LogWarning("File size {FileSize} exceeds limit for inspection {InspectionId}", pdf.Length, id);
                    return BadRequest("File size exceeds the maximum limit of 10MB");
                }

                using var ms = new MemoryStream();
                await pdf.CopyToAsync(ms);
                var pdfBytes = ms.ToArray();

                _logger.LogInformation("Sending certificate email for inspection {InspectionId}, file size: {FileSize} bytes", id, pdfBytes.Length);

                try
                {
                    await _emailService.SendCertificateEmailAsync(pdfBytes, "malcolm@thetylers.co.uk", pdf.FileName);
                    _logger.LogInformation("Certificate email sent successfully for inspection {InspectionId}", id);
                    return Ok(new { Message = "Certificate email sent successfully" });
                }
                catch (Exception emailEx)
                {
                    _logger.LogError(emailEx, "Failed to send email for inspection {InspectionId}, attempting fallback", id);
                    
                    // Development fallback - save to disk
                    var fallbackPath = Path.Combine(Path.GetTempPath(), $"certificate_{id}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");
                    await System.IO.File.WriteAllBytesAsync(fallbackPath, pdfBytes);
                    
                    _logger.LogWarning("Certificate saved to fallback location: {Path}", fallbackPath);
                    
                    return StatusCode(500, new { 
                        Message = "Email sending failed but certificate saved locally", 
                        Error = emailEx.Message,
                        FallbackPath = fallbackPath
                    });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error sending certificate email for inspection {InspectionId}", id);
                
                return StatusCode(500, new { 
                    Message = "An error occurred while sending the certificate email", 
                    Error = ex.Message 
                });
            }
        }
    }
}
