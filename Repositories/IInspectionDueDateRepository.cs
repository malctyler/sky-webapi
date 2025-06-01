using System.Collections.Generic;
using System.Threading.Tasks;
using sky_webapi.DTOs;

namespace sky_webapi.Repositories
{
    public interface IInspectionDueDateRepository
    {
        Task<IEnumerable<InspectionDueDateDto>> GetAllInspectionDueDatesAsync();
    }
}
