using Microsoft.EntityFrameworkCore;
using sky_webapi.Data;
using sky_webapi.Data.Entities;

namespace sky_webapi.Repositories
{
    public class ScheduledInspectionRepository : IScheduledInspectionRepository
    {
        private readonly AppDbContext _context;

        public ScheduledInspectionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ScheduledInspection>> GetAllAsync()
        {
            return await _context.ScheduledInspections
                .Include(si => si.PlantHolding)
                    .ThenInclude(ph => ph.Plant)
                .Include(si => si.PlantHolding)
                    .ThenInclude(ph => ph.Customer)
                .Include(si => si.Inspector)
                .ToListAsync();
        }

        public async Task<ScheduledInspection?> GetByIdAsync(int id)
        {
            return await _context.ScheduledInspections
                .Include(si => si.PlantHolding)
                    .ThenInclude(ph => ph.Plant)
                .Include(si => si.PlantHolding)
                    .ThenInclude(ph => ph.Customer)
                .Include(si => si.Inspector)
                .FirstOrDefaultAsync(si => si.Id == id);
        }

        public async Task<IEnumerable<ScheduledInspection>> GetByHoldingIdAsync(int holdingId)
        {
            return await _context.ScheduledInspections
                .Include(si => si.PlantHolding)
                    .ThenInclude(ph => ph.Plant)
                .Include(si => si.PlantHolding)
                    .ThenInclude(ph => ph.Customer)
                .Include(si => si.Inspector)
                .Where(si => si.HoldingID == holdingId)
                .ToListAsync();
        }

        public async Task<IEnumerable<ScheduledInspection>> GetByInspectorIdAsync(int inspectorId)
        {
            return await _context.ScheduledInspections
                .Include(si => si.PlantHolding)
                    .ThenInclude(ph => ph.Plant)
                .Include(si => si.PlantHolding)
                    .ThenInclude(ph => ph.Customer)
                .Include(si => si.Inspector)
                .Where(si => si.InspectorID == inspectorId)
                .ToListAsync();
        }

        public async Task<IEnumerable<ScheduledInspection>> GetUpcomingAsync(DateTime startDate, DateTime endDate)
        {
            return await _context.ScheduledInspections
                .Include(si => si.PlantHolding)
                    .ThenInclude(ph => ph.Plant)
                .Include(si => si.PlantHolding)
                    .ThenInclude(ph => ph.Customer)
                .Include(si => si.Inspector)
                .Where(si => si.ScheduledDate >= startDate && si.ScheduledDate <= endDate && !si.IsCompleted)
                .OrderBy(si => si.ScheduledDate)
                .ToListAsync();
        }

        public async Task<ScheduledInspection> AddAsync(ScheduledInspection scheduledInspection)
        {
            await _context.ScheduledInspections.AddAsync(scheduledInspection);
            await _context.SaveChangesAsync();
            return scheduledInspection;
        }

        public async Task UpdateAsync(ScheduledInspection scheduledInspection)
        {
            var existingInspection = await _context.ScheduledInspections.FindAsync(scheduledInspection.Id);
            if (existingInspection != null)
            {
                existingInspection.HoldingID = scheduledInspection.HoldingID;
                existingInspection.ScheduledDate = scheduledInspection.ScheduledDate;
                existingInspection.InspectorID = scheduledInspection.InspectorID;
                existingInspection.IsCompleted = scheduledInspection.IsCompleted;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var scheduledInspection = await _context.ScheduledInspections.FindAsync(id);
            if (scheduledInspection != null)
            {
                _context.ScheduledInspections.Remove(scheduledInspection);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.ScheduledInspections.AnyAsync(si => si.Id == id);
        }        public async Task<ScheduledInspection?> GetExistingIncompleteInspectionAsync(int holdingId)
        {
            return await _context.ScheduledInspections
                .Include(si => si.PlantHolding)
                    .ThenInclude(ph => ph.Plant)
                .Include(si => si.PlantHolding)
                    .ThenInclude(ph => ph.Customer)
                .Include(si => si.Inspector)
                .Where(si => si.HoldingID == holdingId && !si.IsCompleted)
                .OrderByDescending(si => si.ScheduledDate)
                .FirstOrDefaultAsync();
        }
    }
}
