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

        public MultiInspectionController(IMultiInspectionService service)
        {
            _service = service;
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
    }
}
