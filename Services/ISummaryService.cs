using System.Collections.Generic;
using System.Threading.Tasks;
using sky_webapi;
using sky_webapi.DTOs;

namespace sky_webapi.Services
{
    public interface ISummaryService
    {
        Task<IEnumerable<SummaryDto>> GetAllSummariesAsync();
        Task<SummaryDto?> GetSummaryByIdAsync(int id);
        Task<SummaryDto> CreateSummaryAsync(SummaryDto summaryDto);
        Task<SummaryDto?> UpdateSummaryAsync(int id, SummaryDto summaryDto);
        Task DeleteSummaryAsync(int id);
    }
}
