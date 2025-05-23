using Microsoft.EntityFrameworkCore;
using sky_webapi.Data;
using sky_webapi.Data.Entities;

namespace sky_webapi.Repositories
{
    public class AllPlantRepository : IAllPlantRepository
    {
        private readonly AppDbContext _context;

        public AllPlantRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AllPlantEntity>> GetAllAsync()
        {
            return await _context.Allplant.ToListAsync();
        }

        public async Task<AllPlantEntity?> GetByIdAsync(int id)
        {
            return await _context.Allplant
                .FirstOrDefaultAsync(p => p.PlantNameID == id);
        }

        public async Task<IEnumerable<AllPlantEntity>> GetByCategoryAsync(int categoryId)
        {
            return await _context.Allplant
                .Where(p => p.PlantCategory == categoryId)
                .ToListAsync();
        }

        public async Task<AllPlantEntity> AddAsync(AllPlantEntity plant)
        {
            _context.Allplant.Add(plant);
            await _context.SaveChangesAsync();
            return plant;
        }

        public async Task UpdateAsync(AllPlantEntity plant)
        {
            _context.Entry(plant).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var plant = await _context.Allplant.FindAsync(id);
            if (plant != null)
            {
                _context.Allplant.Remove(plant);
                await _context.SaveChangesAsync();
            }
        }
    }
}
