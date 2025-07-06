using Microsoft.EntityFrameworkCore;
using sky_webapi.Data;
using sky_webapi.Data.Entities;

namespace sky_webapi.Repositories
{
    public class InspectionRepository : IInspectionRepository
    {
        private readonly AppDbContext _context;

        public InspectionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Inspection>> GetAllAsync()
        {
            return await _context.Inspections
                .Include(i => i.PlantHolding!)
                .ThenInclude(ph => ph!.Plant!)
                .ThenInclude(p => p!.Category)                .Include(i => i.PlantHolding!)
                .ThenInclude(ph => ph!.Customer)
                .Include(i => i.Inspector)
                .ToListAsync();
        }

        public async Task<Inspection?> GetByIdAsync(int id)
        {
            return await _context.Inspections
                .Include(i => i.PlantHolding!)
                .ThenInclude(ph => ph!.Plant!)
                .ThenInclude(p => p!.Category)                .Include(i => i.PlantHolding!)
                .ThenInclude(ph => ph!.Customer)
                .Include(i => i.Inspector)
                .FirstOrDefaultAsync(i => i.UniqueRef == id);
        }

        public async Task<IEnumerable<Inspection>> GetByPlantHoldingAsync(int holdingId)
        {
            return await _context.Inspections
                .Include(i => i.PlantHolding!)
                .ThenInclude(ph => ph!.Plant!)
                .ThenInclude(p => p!.Category)                .Include(i => i.PlantHolding!)
                .ThenInclude(ph => ph!.Customer)
                .Include(i => i.Inspector)
                .Where(i => i.HoldingID == holdingId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Inspection>> GetByCustomerAndDateAsync(int customerId, DateTime inspectionDate)
        {
            return await _context.Inspections
                .Include(i => i.PlantHolding!)
                .ThenInclude(ph => ph!.Plant!)
                .ThenInclude(p => p!.Category)
                .Include(i => i.PlantHolding!)
                .ThenInclude(ph => ph!.Customer)
                .Include(i => i.Inspector)
                .Where(i => i.PlantHolding!.Customer!.CustID == customerId && 
                           i.InspectionDate.HasValue && 
                           i.InspectionDate.Value.Date == inspectionDate.Date)
                .ToListAsync();
        }

        public async Task<Inspection> AddAsync(Inspection inspection)
        {
            _context.Inspections.Add(inspection);
            await _context.SaveChangesAsync();
            return inspection;
        }

        public async Task UpdateAsync(Inspection inspection)
        {
            _context.Entry(inspection).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var inspection = await _context.Inspections.FindAsync(id);
            if (inspection != null)
            {
                _context.Inspections.Remove(inspection);
                await _context.SaveChangesAsync();
            }
        }
    }
}
