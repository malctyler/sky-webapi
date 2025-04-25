using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using sky_webapi.DTOs;
using sky_webapi.Services;
using Microsoft.EntityFrameworkCore;

namespace sky_webapi.Controllers
{
    [Authorize]  // Requires authentication for all endpoints
    [Route("api/[controller]")]
    [ApiController]
    public class PlantHoldingController : ControllerBase
    {
        private readonly IPlantHoldingService _service;

        public PlantHoldingController(IPlantHoldingService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlantHoldingReadDto>>> GetAllPlantHoldings()
        {
            // If user is a customer, only return their plant holdings
            if (User.HasClaim("IsCustomer", "True"))
            {
                var customerIdClaim = User.Claims.FirstOrDefault(c => c.Type == "CustomerId");
                if (customerIdClaim == null)
                {
                    return Forbid();
                }

                var customerId = int.Parse(customerIdClaim.Value);
                var customerPlantHoldings = await _service.GetPlantHoldingsByCustomerIdAsync(customerId);
                return Ok(customerPlantHoldings);
            }

            // Staff can see all plant holdings
            var plantHoldings = await _service.GetAllPlantHoldingsAsync();
            return Ok(plantHoldings);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PlantHoldingReadDto>> GetPlantHolding(int id)
        {
            var plantHolding = await _service.GetPlantHoldingByIdAsync(id);
            if (plantHolding == null)
            {
                return NotFound();
            }

            // If user is a customer, verify they own this plant holding
            if (User.HasClaim("IsCustomer", "True"))
            {
                var customerIdClaim = User.Claims.FirstOrDefault(c => c.Type == "CustomerId");
                if (customerIdClaim == null || plantHolding.CustID != int.Parse(customerIdClaim.Value))
                {
                    return Forbid();
                }
            }

            return Ok(plantHolding);
        }

        [HttpPost]
        [Authorize(Roles = "Staff")]  // Only staff can create plant holdings
        public async Task<ActionResult<PlantHoldingReadDto>> CreatePlantHolding(PlantHoldingDto plantHoldingDto)
        {
            var createdPlantHolding = await _service.CreatePlantHoldingAsync(plantHoldingDto);
            return CreatedAtAction(
                nameof(GetPlantHolding),
                new { id = createdPlantHolding.HoldingID },
                createdPlantHolding);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Staff")]  // Only staff can update plant holdings
        public async Task<ActionResult<PlantHoldingReadDto>> UpdatePlantHolding(int id, PlantHoldingDto plantHoldingDto)
        {
            try
            {
                var updatedPlantHolding = await _service.UpdatePlantHoldingAsync(id, plantHoldingDto);
                return Ok(updatedPlantHolding);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Staff")]  // Only staff can delete plant holdings
        public async Task<IActionResult> DeletePlantHolding(int id)
        {
            try
            {
                await _service.DeletePlantHoldingAsync(id);
                return NoContent();
            }
            catch (DbUpdateException ex) when (ex.InnerException?.Message.Contains("FK_Inspections_PlantHoldings_HoldingID") == true)
            {
                return BadRequest("This plant holding cannot be deleted because it has associated inspections.");
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while deleting the plant holding.");
            }
        }
    }
}
