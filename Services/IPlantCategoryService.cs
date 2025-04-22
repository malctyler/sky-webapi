using sky_webapi.DTOs;

namespace sky_webapi.Services
{
    public interface IPlantCategoryService
    {
        Task<IEnumerable<PlantCategoryDto>> GetAllCategoriesAsync();
        Task<PlantCategoryDto?> GetCategoryByIdAsync(int id);
        Task<PlantCategoryDto> CreateCategoryAsync(PlantCategoryDto categoryDto);
        Task UpdateCategoryAsync(int id, PlantCategoryDto categoryDto);
        Task DeleteCategoryAsync(int id);
    }
}
