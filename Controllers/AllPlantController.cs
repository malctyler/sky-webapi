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
        private readonly IAllPlantService _service;

        public AllPlantController(IAllPlantService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Staff")] // Allow both Admin and Staff to read
        public async Task<ActionResult<IEnumerable<AllPlantDto>>> GetAllPlants()
        {
            var plants = await _service.GetAllPlantsAsync();
            return Ok(plants);
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
        public async Task<ActionResult<IEnumerable<AllPlantDto>>> GetPlantsByCategory(int categoryId)
        {
            var plants = await _service.GetPlantsByCategoryAsync(categoryId);
            return Ok(plants);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")] // Only Admin can create
        public async Task<ActionResult<AllPlantDto>> CreatePlant(AllPlantDto plantDto)
        {
            var result = await _service.CreatePlantAsync(plantDto);
            return CreatedAtAction(nameof(GetPlant), new { id = result.PlantNameID }, result);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")] // Only Admin can update
        public async Task<IActionResult> UpdatePlant(int id, AllPlantDto plantDto)
        {
            await _service.UpdatePlantAsync(id, plantDto);
            return NoContent();
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
