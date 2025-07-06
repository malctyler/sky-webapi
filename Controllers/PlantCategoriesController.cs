using Microsoft.AspNetCore.Mvc;
using sky_webapi.DTOs;
using sky_webapi.Services;
using Microsoft.AspNetCore.Authorization;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlantCategoriesController : ControllerBase
    {
        private readonly IPlantCategoryService _service;

        public PlantCategoriesController(IPlantCategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Staff")] // Allow both Admin and Staff to read categories
        public async Task<ActionResult<IEnumerable<PlantCategoryDto>>> GetAllCategories()
        {
            var categories = await _service.GetAllCategoriesAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,Staff")] // Allow both Admin and Staff to read categories
        public async Task<ActionResult<PlantCategoryDto>> GetCategory(int id)
        {
            var category = await _service.GetCategoryByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")] // Only admin can create categories
        public async Task<ActionResult<PlantCategoryDto>> CreateCategory(PlantCategoryDto categoryDto)
        {
            var result = await _service.CreateCategoryAsync(categoryDto);
            return CreatedAtAction(nameof(GetCategory), new { id = result.CategoryID }, result);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")] // Only admin can update categories
        public async Task<IActionResult> UpdateCategory(int id, PlantCategoryDto categoryDto)
        {
            await _service.UpdateCategoryAsync(id, categoryDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")] // Only admin can delete categories
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _service.DeleteCategoryAsync(id);
            return NoContent();
        }
    }
}
