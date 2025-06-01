using System.Collections.Generic;
using System.Threading.Tasks;
using sky_webapi.DTOs;
using sky_webapi.Repositories;

namespace sky_webapi.Services
{
    public class InspectionDueDateService : IInspectionDueDateService
    {
        private readonly IInspectionDueDateRepository _repository;

        public InspectionDueDateService(IInspectionDueDateRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<InspectionDueDateDto>> GetAllInspectionDueDatesAsync()
        {
            return await _repository.GetAllInspectionDueDatesAsync();
        }
    }
}
