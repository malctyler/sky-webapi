using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using sky_webapi.DTOs;
using sky_webapi.Services;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Staff")]
    public class MultiInspectionController : ControllerBase
    {
        private readonly IMultiInspectionService _service;
        private readonly IEmailService _emailService;
        private readonly ILogger<MultiInspectionController> _logger;

        public MultiInspectionController(IMultiInspectionService service, IEmailService emailService, ILogger<MultiInspectionController> logger)
        {
            _service = service;
            _emailService = emailService;
            _logger = logger;
        }

        /// <summary>
        /// Get plant categories that have holdings for a specific customer
        /// </summary>
        /// <param name="customerId">Customer ID</param>
        /// <returns>List of plant categories with holdings for the customer</returns>
        [HttpGet("categories/{customerId}")]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<PlantCategoryDto>>> GetCategoriesWithHoldingsByCustomer(int customerId)
        {
            try
            {
                var categories = await _service.GetCategoriesWithHoldingsByCustomerAsync(customerId);
                return Ok(categories);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to retrieve categories with holdings: {ex.Message}");
            }
        }

        /// <summary>
        /// Get plant holdings for multi-inspection by customer and categories
        /// </summary>
        /// <param name="request">Customer ID and category IDs</param>
        /// <returns>List of plant holdings suitable for multi-inspection</returns>
        [HttpPost("items")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<MultiInspectionItemDto>>> GetMultiInspectionItems([FromBody] MultiInspectionRequestDto request)
        {
            try
            {
                var items = await _service.GetMultiInspectionItemsAsync(request.CustomerId, request.CategoryIds);
                return Ok(items);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to retrieve multi-inspection items: {ex.Message}");
            }
        }

        /// <summary>
        /// Create multiple inspections from a multi-inspection request
        /// </summary>
        /// <param name="createDto">Multi-inspection creation data</param>
        /// <returns>List of created inspections</returns>
        [HttpPost("create")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<InspectionReadDto>>> CreateMultiInspection([FromBody] CreateMultiInspectionDto createDto)
        {
            try
            {
                var inspections = await _service.CreateMultiInspectionAsync(createDto);
                return Ok(inspections);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to create multi-inspection: {ex.Message}");
            }
        }

        /// <summary>
        /// Get completed multi-inspections for a customer and date
        /// </summary>
        /// <param name="customerId">Customer ID</param>
        /// <param name="inspectionDate">Inspection date in YYYY-MM-DD format</param>
        /// <returns>List of completed inspections for the customer and date</returns>
        [HttpGet("completed/{customerId}/{inspectionDate}")]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<InspectionReadDto>>> GetCompletedMultiInspections(int customerId, string inspectionDate)
        {
            try
            {
                var inspections = await _service.GetCompletedMultiInspectionsAsync(customerId, inspectionDate);
                return Ok(inspections);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to retrieve completed multi-inspections: {ex.Message}");
            }
        }

        /// <summary>
        /// Send multi-inspection certificate via email
        /// </summary>
        /// <param name="pdf">PDF file to send</param>
        /// <param name="email">Optional customer email (uses development default if not provided)</param>
        /// <returns>Success message</returns>
        [HttpPost("email")]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> EmailMultiCertificate(IFormFile pdf, [FromForm] string? email = null)
        {
            try
            {
                _logger.LogInformation("Attempting to send multi-inspection certificate email");

                if (pdf == null || pdf.Length == 0)
                {
                    _logger.LogWarning("No PDF file received or file is empty");
                    return BadRequest("No PDF file received or file is empty");
                }

                // Validate PDF file type
                if (!pdf.ContentType.Equals("application/pdf", StringComparison.OrdinalIgnoreCase))
                {
                    _logger.LogWarning("Invalid file type {ContentType}", pdf.ContentType);
                    return BadRequest("Only PDF files are allowed");
                }

                // Limit file size (e.g., 10MB)
                if (pdf.Length > 10 * 1024 * 1024)
                {
                    _logger.LogWarning("File size {FileSize} exceeds limit", pdf.Length);
                    return BadRequest("File size exceeds the maximum limit of 10MB");
                }

                using var ms = new MemoryStream();
                await pdf.CopyToAsync(ms);
                var pdfBytes = ms.ToArray();

                // Use the provided email or default to development email
                var recipientEmail = email ?? "malcolm@thetylers.co.uk";

                _logger.LogInformation("Sending multi-inspection certificate email, file size: {FileSize} bytes, recipient: {Email}", pdfBytes.Length, recipientEmail);

                await _emailService.SendCertificateEmailAsync(pdfBytes, recipientEmail, pdf.FileName);
                _logger.LogInformation("Multi-inspection certificate email sent successfully");
                
                return Ok(new { Message = "Multi-inspection certificate email sent successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error sending multi-inspection certificate email");
                return StatusCode(500, new { 
                    Message = "An error occurred while sending the multi-inspection certificate email", 
                    Error = ex.Message 
                });
            }
        }
    }
}
