using System.Collections.Generic;
using System.Threading.Tasks;
using sky_webapi;
using sky_webapi.Data.Entities;

namespace sky_webapi.Repositories
{
    public interface ISummaryRepository
    {
        Task<IEnumerable<Summary>> GetSummariesAsync();
        Task<Summary?> GetSummaryAsync(int id);
        Task AddSummaryAsync(Summary summary);
        Task UpdateSummaryAsync(Summary summary);
        Task DeleteSummaryAsync(int id);
        Task<bool> SummaryExistsAsync(int id);
    }
}
