using System.Collections.Generic;
using System.Threading.Tasks;
using sky_webapi.DTOs;

namespace sky_webapi.Services
{
    public interface IInspectionDueDateService
    {
        Task<IEnumerable<InspectionDueDateDto>> GetAllInspectionDueDatesAsync();
    }
}
