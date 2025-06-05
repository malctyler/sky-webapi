using sky_webapi.Data.Entities;

namespace sky_webapi.Repositories
{
    public interface IScheduledInspectionRepository
    {
        Task<IEnumerable<ScheduledInspection>> GetAllAsync();
        Task<ScheduledInspection?> GetByIdAsync(int id);
        Task<IEnumerable<ScheduledInspection>> GetByHoldingIdAsync(int holdingId);
        Task<IEnumerable<ScheduledInspection>> GetByInspectorIdAsync(int inspectorId);
        Task<IEnumerable<ScheduledInspection>> GetUpcomingAsync(DateTime startDate, DateTime endDate);
        Task<ScheduledInspection> AddAsync(ScheduledInspection scheduledInspection);
        Task UpdateAsync(ScheduledInspection scheduledInspection);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
        Task<ScheduledInspection?> GetExistingIncompleteInspectionAsync(int holdingId);
        Task<IEnumerable<ScheduledInspection>> GetExistingIncompleteInspectionsAsync(int holdingId);
    }
}
