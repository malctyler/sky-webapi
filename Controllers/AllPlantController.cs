using Microsoft.AspNetCore.Mvc;
using sky_webapi.DTOs;
using sky_webapi.Services;
using Microsoft.AspNetCore.Authorization;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Base authorization for the controller
    public class AllPlantController : ControllerBase
    {
        private readonly IAllplantervice _service;

        public AllPlantController(IAllplantervice service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Staff")] // Allow both Admin and Staff to read
        public async Task<ActionResult<IEnumerable<AllPlantDto>>> GetAllplant()
        {
            var plant = await _service.GetAllplantAsync();
            return Ok(plant);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,Staff")] // Allow both Admin and Staff to read
        public async Task<ActionResult<AllPlantDto>> GetPlant(int id)
        {
            var plant = await _service.GetPlantByIdAsync(id);
            if (plant == null)
            {
                return NotFound();
            }
            return Ok(plant);
        }

        [HttpGet("category/{categoryId}")]
        [Authorize(Roles = "Admin,Staff")] // Allow both Admin and Staff to read
        public async Task<ActionResult<IEnumerable<AllPlantDto>>> GetplantByCategory(int categoryId)
        {
            var plant = await _service.GetplantByCategoryAsync(categoryId);
            return Ok(plant);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")] // Only Admin can create
        public async Task<ActionResult<AllPlantDto>> CreatePlant(AllPlantDto plantDto)
        {
            try
            {
                var result = await _service.CreatePlantAsync(plantDto);
                return CreatedAtAction(nameof(GetPlant), new { id = result.PlantNameID }, result);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")] // Only Admin can update
        public async Task<IActionResult> UpdatePlant(int id, AllPlantDto plantDto)
        {
            try
            {
                await _service.UpdatePlantAsync(id, plantDto);
                return NoContent();
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")] // Only Admin can delete
        public async Task<IActionResult> DeletePlant(int id)
        {
            await _service.DeletePlantAsync(id);
            return NoContent();
        }
    }
}
