using sky_webapi.DTOs;
using sky_webapi.Data.Entities;
using sky_webapi.Repositories;
using sky_webapi.Exceptions;

namespace sky_webapi.Services
{
    public class ScheduledInspectionService : IScheduledInspectionService
    {
        private readonly IScheduledInspectionRepository _repository;

        public ScheduledInspectionService(IScheduledInspectionRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ScheduledInspectionDto>> GetAllScheduledInspectionsAsync()
        {
            var inspections = await _repository.GetAllAsync();
            return inspections.Select(MapToDto);
        }

        public async Task<ScheduledInspectionDto?> GetScheduledInspectionByIdAsync(int id)
        {
            var inspection = await _repository.GetByIdAsync(id);
            return inspection != null ? MapToDto(inspection) : null;
        }

        public async Task<IEnumerable<ScheduledInspectionDto>> GetScheduledInspectionsByHoldingIdAsync(int holdingId)
        {
            var inspections = await _repository.GetByHoldingIdAsync(holdingId);
            return inspections.Select(MapToDto);
        }

        public async Task<IEnumerable<ScheduledInspectionDto>> GetScheduledInspectionsByInspectorIdAsync(int inspectorId)
        {
            var inspections = await _repository.GetByInspectorIdAsync(inspectorId);
            return inspections.Select(MapToDto);
        }

        public async Task<IEnumerable<ScheduledInspectionDto>> GetUpcomingScheduledInspectionsAsync(DateTime startDate, DateTime endDate)
        {
            var inspections = await _repository.GetUpcomingAsync(startDate, endDate);
            return inspections.Select(MapToDto);
        }        public async Task<ScheduledInspectionDto> CreateScheduledInspectionAsync(CreateUpdateScheduledInspectionDto createDto)
        {
            // Check for existing incomplete inspections for this holding
            if (!createDto.Force)
            {                var existingInspections = await _repository.GetExistingIncompleteInspectionsAsync(createDto.HoldingID);
                if (existingInspections.Any())
                {
                    var serialNumber = existingInspections.First().PlantHolding?.SerialNumber ?? "unknown";
                    var existingDates = existingInspections.Select(i => i.ScheduledDate);
                    throw new DuplicateInspectionException(existingDates, serialNumber);
                }
            }

            var inspection = new ScheduledInspection
            {
                HoldingID = createDto.HoldingID,
                ScheduledDate = createDto.ScheduledDate,
                Location = createDto.Location,
                Notes = createDto.Notes,
                InspectorID = createDto.InspectorID,
                IsCompleted = createDto.IsCompleted
            };

            var result = await _repository.AddAsync(inspection);
            var createdInspection = await _repository.GetByIdAsync(result.Id);
            return MapToDto(createdInspection!);
        }        public async Task<ScheduledInspectionDto> UpdateScheduledInspectionAsync(int id, CreateUpdateScheduledInspectionDto updateDto)
        {            var inspection = new ScheduledInspection
            {
                Id = id,
                HoldingID = updateDto.HoldingID,
                ScheduledDate = updateDto.ScheduledDate,
                Location = updateDto.Location,
                Notes = updateDto.Notes,
                InspectorID = updateDto.InspectorID,
                IsCompleted = updateDto.IsCompleted
            };

            await _repository.UpdateAsync(inspection);
            var updatedInspection = await _repository.GetByIdAsync(id);
            return MapToDto(updatedInspection!);
        }

        public async Task DeleteScheduledInspectionAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        private static ScheduledInspectionDto MapToDto(ScheduledInspection inspection)
        {            return new ScheduledInspectionDto
            {
                Id = inspection.Id,
                HoldingID = inspection.HoldingID,
                ScheduledDate = inspection.ScheduledDate,
                Location = inspection.Location,
                Notes = inspection.Notes,
                InspectorID = inspection.InspectorID,
                IsCompleted = inspection.IsCompleted,
                PlantDescription = inspection.PlantHolding?.Plant?.PlantDescription,
                SerialNumber = inspection.PlantHolding?.SerialNumber,
                CustomerCompanyName = inspection.PlantHolding?.Customer?.CompanyName,
                CustomerContactName = inspection.PlantHolding?.Customer != null 
                    ? $"{inspection.PlantHolding.Customer.ContactTitle} {inspection.PlantHolding.Customer.ContactFirstNames} {inspection.PlantHolding.Customer.ContactSurname}"
                    : null,
                InspectorName = inspection.Inspector?.InspectorsName
            };
        }
    }
}
