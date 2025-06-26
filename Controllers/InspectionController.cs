using Microsoft.AspNetCore.Mvc;
using sky_webapi.DTOs;
using sky_webapi.Services;
using Microsoft.AspNetCore.Authorization;

namespace sky_webapi.Controllers
{
    [Authorize(Roles = "Staff")]  // Only staff members can access inspector endpoints
    [ApiController]
    [Route("api/[controller]")]
    public class InspectionController : ControllerBase
    {
        private readonly IInspectionService _service;
        private readonly IEmailService _emailService;
        private readonly ILogger<InspectionController> _logger;

        public InspectionController(IInspectionService service, IEmailService emailService, ILogger<InspectionController> logger)
        {
            _service = service;
            _emailService = emailService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InspectionReadDto>>> GetAllInspections()
        {
            var inspections = await _service.GetAllInspectionsAsync();
            return Ok(inspections);
        }

        [HttpGet("{id}")]
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
        public async Task<ActionResult<IEnumerable<InspectionReadDto>>> GetByPlantHolding(int holdingId)
        {
            var inspections = await _service.GetInspectionsByPlantHoldingAsync(holdingId);
            return Ok(inspections);
        }

        [HttpPost]
        public async Task<ActionResult<InspectionReadDto>> CreateInspection(CreateUpdateInspectionDto createDto)
        {
            var createdInspection = await _service.CreateInspectionAsync(createDto);
            return CreatedAtAction(nameof(GetInspection), new { id = createdInspection.UniqueRef }, createdInspection);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<InspectionReadDto>> UpdateInspection(int id, CreateUpdateInspectionDto updateDto)
        {
            var updatedInspection = await _service.UpdateInspectionAsync(id, updateDto);
            return Ok(updatedInspection);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInspection(int id)
        {
            await _service.DeleteInspectionAsync(id);
            return NoContent();
        }

        [HttpPost("{id}/email")]
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
