using Microsoft.EntityFrameworkCore;
using sky_webapi.Data;
using sky_webapi.Data.Entities;

namespace sky_webapi.Repositories
{
    public class PlantCategoryRepository : IPlantCategoryRepository
    {
        private readonly AppDbContext _context;

        public PlantCategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PlantCategoryEntity>> GetAllAsync()
        {
            return await _context.PlantCategories
                .Include(c => c.plant)
                .ToListAsync();
        }

        public async Task<PlantCategoryEntity?> GetByIdAsync(int id)
        {
            return await _context.PlantCategories
                .Include(c => c.plant)
                .FirstOrDefaultAsync(c => c.CategoryID == id);
        }

        public async Task<PlantCategoryEntity> AddAsync(PlantCategoryEntity category)
        {
            _context.PlantCategories.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task UpdateAsync(PlantCategoryEntity category)
        {
            // Use Update method which handles entity tracking automatically
            _context.PlantCategories.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var category = await _context.PlantCategories.FindAsync(id);
            if (category != null)
            {
                _context.PlantCategories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }
    }
}
