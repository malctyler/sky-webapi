using Microsoft.EntityFrameworkCore;
using sky_webapi.Data;
using sky_webapi.Data.Entities;

namespace sky_webapi.Repositories
{
    public class InspectorRepository : IInspectorRepository
    {
        private readonly AppDbContext _context;

        public InspectorRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<InspectorEntity>> GetAllAsync()
        {
            return await _context.Inspectors
                .Include(i => i.Inspections)
                .ToListAsync();
        }

        public async Task<InspectorEntity?> GetByIdAsync(int id)
        {
            return await _context.Inspectors
                .Include(i => i.Inspections)
                .FirstOrDefaultAsync(i => i.InspectorID == id);
        }

        public async Task<InspectorEntity> AddAsync(InspectorEntity inspector)
        {
            _context.Inspectors.Add(inspector);
            await _context.SaveChangesAsync();
            return inspector;
        }

        public async Task UpdateAsync(InspectorEntity inspector)
        {
            _context.Entry(inspector).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var inspector = await _context.Inspectors.FindAsync(id);
            if (inspector != null)
            {
                _context.Inspectors.Remove(inspector);
                await _context.SaveChangesAsync();
            }
        }
    }
}
