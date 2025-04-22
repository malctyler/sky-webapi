using sky_webapi.Data.Entities;

namespace sky_webapi.Repositories
{
    public interface IStatusRepository
    {
        Task<IEnumerable<Status>> GetStatusAsync();
        Task<Status?> GetStatusAsync(int id);
        Task<Status> AddStatusAsync(Status status);
        Task UpdateStatusAsync(Status status);
        Task DeleteStatusAsync(int id);
        Task<bool> StatusExistsAsync(int id);
    }
}
