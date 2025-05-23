using sky_webapi.Data.Entities;
using sky_webapi.DTOs;
using sky_webapi.Repositories;

namespace sky_webapi.Services
{
    public class PlantCategoryService : IPlantCategoryService
    {
        private readonly IPlantCategoryRepository _repository;

        public PlantCategoryService(IPlantCategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<PlantCategoryDto>> GetAllCategoriesAsync()
        {
            var categories = await _repository.GetAllAsync();
            return categories.Select(c => new PlantCategoryDto
            {
                CategoryID = c.CategoryID,
                CategoryDescription = c.CategoryDescription
            });
        }

        public async Task<PlantCategoryDto?> GetCategoryByIdAsync(int id)
        {
            var category = await _repository.GetByIdAsync(id);
            if (category == null) return null;

            return new PlantCategoryDto
            {
                CategoryID = category.CategoryID,
                CategoryDescription = category.CategoryDescription
            };
        }

        public async Task<PlantCategoryDto> CreateCategoryAsync(PlantCategoryDto categoryDto)
        {
            // Check for existing category with same description
            var existingCategories = await _repository.GetAllAsync();
            var existingCategory = existingCategories.FirstOrDefault(c => 
                c.CategoryDescription?.Trim().ToLower() == categoryDto.CategoryDescription?.Trim().ToLower());
            
            if (existingCategory != null)
            {
                throw new InvalidOperationException($"A category with description '{categoryDto.CategoryDescription}' already exists.");
            }

            var category = new PlantCategoryEntity
            {
                CategoryDescription = categoryDto.CategoryDescription?.Trim()
            };

            var result = await _repository.AddAsync(category);
            return new PlantCategoryDto
            {
                CategoryID = result.CategoryID,
                CategoryDescription = result.CategoryDescription
            };
        }

        public async Task UpdateCategoryAsync(int id, PlantCategoryDto categoryDto)
        {
            // Check for existing category with same description
            var existingCategories = await _repository.GetAllAsync();
            var existingCategory = existingCategories.FirstOrDefault(c => 
                c.CategoryDescription?.Trim().ToLower() == categoryDto.CategoryDescription?.Trim().ToLower()
                && c.CategoryID != id);
            
            if (existingCategory != null)
            {
                throw new InvalidOperationException($"A category with description '{categoryDto.CategoryDescription}' already exists.");
            }

            var category = new PlantCategoryEntity
            {
                CategoryID = id,
                CategoryDescription = categoryDto.CategoryDescription?.Trim()
            };

            await _repository.UpdateAsync(category);
        }

        public async Task DeleteCategoryAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
