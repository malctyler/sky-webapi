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
        {            var inspections = await _context.Inspections
                .Include(i => i.PlantHolding!)
                .ThenInclude(ph => ph.Customer!)
                .Include(i => i.PlantHolding!)
                .ThenInclude(ph => ph.Plant!)
                .ThenInclude(p => p.Category!)
                .Where(i => i.PlantHolding != null 
                    && i.PlantHolding.Customer != null 
                    && i.PlantHolding.Plant != null 
                    && i.PlantHolding.Plant.Category != null)
                .ToListAsync();            var dtos = inspections.Select(i =>
            {
                var lastInspection = i.InspectionDate.GetValueOrDefault(DateTime.MinValue);
                var dueDate = lastInspection.AddMonths(i.PlantHolding!.InspectionFrequency);
                
                return new InspectionDueDateDto
                {
                    LastInspection = lastInspection,
                    DueDate = dueDate,
                    CompanyName = i.PlantHolding.Customer!.CompanyName ?? string.Empty,
                    CategoryDescription = i.PlantHolding.Plant!.Category!.CategoryDescription ?? string.Empty,
                    SerialNumber = i.PlantHolding.SerialNumber ?? string.Empty,
                    InspectionFrequency = i.PlantHolding.InspectionFrequency
                };
            });

            return dtos
                .OrderBy(x => x.DueDate.Ticks)  // Explicitly sort by DateTime ticks
                .ToList();
        }
    }
}
