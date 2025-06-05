using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using sky_webapi.DTOs;
using sky_webapi.Services;
using sky_webapi.Exceptions;

namespace sky_webapi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduledInspectionController : ControllerBase
    {
        private readonly IScheduledInspectionService _service;

        public ScheduledInspectionController(IScheduledInspectionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ScheduledInspectionDto>>> GetAllScheduledInspections()
        {
            var inspections = await _service.GetAllScheduledInspectionsAsync();
            return Ok(inspections);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ScheduledInspectionDto>> GetScheduledInspection(int id)
        {
            var inspection = await _service.GetScheduledInspectionByIdAsync(id);
            if (inspection == null)
            {
                return NotFound();
            }
            return Ok(inspection);
        }

        [HttpGet("holding/{holdingId}")]
        public async Task<ActionResult<IEnumerable<ScheduledInspectionDto>>> GetByHolding(int holdingId)
        {
            var inspections = await _service.GetScheduledInspectionsByHoldingIdAsync(holdingId);
            return Ok(inspections);
        }

        [HttpGet("inspector/{inspectorId}")]
        public async Task<ActionResult<IEnumerable<ScheduledInspectionDto>>> GetByInspector(int inspectorId)
        {
            var inspections = await _service.GetScheduledInspectionsByInspectorIdAsync(inspectorId);
            return Ok(inspections);
        }

        [HttpGet("upcoming")]
        public async Task<ActionResult<IEnumerable<ScheduledInspectionDto>>> GetUpcoming([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var inspections = await _service.GetUpcomingScheduledInspectionsAsync(startDate, endDate);
            return Ok(inspections);
        }        [HttpPost]
        [Authorize(Roles = "Staff")]
        public async Task<ActionResult<ScheduledInspectionDto>> CreateScheduledInspection(CreateUpdateScheduledInspectionDto createDto)
        {
            try 
            {
                var createdInspection = await _service.CreateScheduledInspectionAsync(createDto);
                return CreatedAtAction(
                    nameof(GetScheduledInspection),
                    new { id = createdInspection.Id },
                    createdInspection);
            }            catch (DuplicateInspectionException ex)
            {
                return StatusCode(409, new { 
                    message = ex.Message, 
                    existingDate = ex.ExistingInspectionDate.ToString("o"),
                    serialNumber = ex.SerialNumber
                });
            }
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Staff")]
        public async Task<ActionResult<ScheduledInspectionDto>> UpdateScheduledInspection(int id, CreateUpdateScheduledInspectionDto updateDto)
        {
            try
            {
                var updatedInspection = await _service.UpdateScheduledInspectionAsync(id, updateDto);
                return Ok(updatedInspection);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> DeleteScheduledInspection(int id)
        {
            await _service.DeleteScheduledInspectionAsync(id);
            return NoContent();
        }
    }
}
