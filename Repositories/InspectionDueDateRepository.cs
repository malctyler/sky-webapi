using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sky_webapi.Data;
using sky_webapi.DTOs;

namespace sky_webapi.Repositories
{
    public class InspectionDueDateRepository : IInspectionDueDateRepository
    {
        private readonly AppDbContext _context;

        public InspectionDueDateRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<InspectionDueDateDto>> GetAllInspectionDueDatesAsync()
        {
            var inspections = await _context.Inspections
                .Include(i => i.PlantHolding!)
                .ThenInclude(ph => ph.Customer!)
                .Include(i => i.PlantHolding!)
                .ThenInclude(ph => ph.Plant!)
                .ThenInclude(p => p.Category!)
                .Where(i => i.PlantHolding != null 
                    && i.PlantHolding.Customer != null 
                    && i.PlantHolding.Plant != null 
                    && i.PlantHolding.Plant.Category != null)
                .OrderByDescending(i => i.InspectionDate)  // Get the most recent inspection for each holding
                .ToListAsync();

            var holdingGroups = inspections.GroupBy(i => i.PlantHolding!.HoldingID)
                .Select(g => g.First());  // Take the most recent inspection for each holding

            var scheduledInspections = await _context.ScheduledInspections
                .Where(si => !si.IsCompleted)
                .GroupBy(si => si.HoldingID)
                .Select(g => new { HoldingID = g.Key, Count = g.Count() })
                .ToListAsync();

            var dtos = holdingGroups.Select(i =>
            {
                var lastInspection = i.InspectionDate.GetValueOrDefault(DateTime.MinValue);
                var dueDate = lastInspection.AddMonths(i.PlantHolding!.InspectionFrequency);
                var scheduledCount = scheduledInspections
                    .FirstOrDefault(si => si.HoldingID == i.PlantHolding.HoldingID)?.Count ?? 0;

                return new InspectionDueDateDto
                {
                    HoldingID = i.PlantHolding!.HoldingID,
                    LastInspection = lastInspection,
                    DueDate = dueDate,
                    CompanyName = i.PlantHolding.Customer!.CompanyName ?? string.Empty,
                    CategoryDescription = i.PlantHolding.Plant!.Category!.CategoryDescription ?? string.Empty,
                    SerialNumber = i.PlantHolding.SerialNumber ?? string.Empty,
                    InspectionFrequency = i.PlantHolding.InspectionFrequency,
                    ScheduledInspectionCount = scheduledCount
                };
            });

            return dtos
                .OrderBy(x => x.DueDate.Ticks)  // Explicitly sort by DateTime ticks
                .ToList();
        }
    }
}
