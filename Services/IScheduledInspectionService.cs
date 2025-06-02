using sky_webapi.DTOs;

namespace sky_webapi.Services
{
    public interface IScheduledInspectionService
    {
        Task<IEnumerable<ScheduledInspectionDto>> GetAllScheduledInspectionsAsync();
        Task<ScheduledInspectionDto?> GetScheduledInspectionByIdAsync(int id);
        Task<IEnumerable<ScheduledInspectionDto>> GetScheduledInspectionsByHoldingIdAsync(int holdingId);
        Task<IEnumerable<ScheduledInspectionDto>> GetScheduledInspectionsByInspectorIdAsync(int inspectorId);
        Task<IEnumerable<ScheduledInspectionDto>> GetUpcomingScheduledInspectionsAsync(DateTime startDate, DateTime endDate);        Task<ScheduledInspectionDto> CreateScheduledInspectionAsync(CreateUpdateScheduledInspectionDto createDto);
        Task<ScheduledInspectionDto> UpdateScheduledInspectionAsync(int id, CreateUpdateScheduledInspectionDto updateDto);
        Task DeleteScheduledInspectionAsync(int id);
    }
}
