using sky_webapi.Data.Entities;

namespace sky_webapi.Repositories
{
    public interface IInspectionRepository
    {
        Task<IEnumerable<Inspection>> GetAllAsync();
        Task<Inspection?> GetByIdAsync(int id);
        Task<IEnumerable<Inspection>> GetByPlantHoldingAsync(int holdingId);
        Task<IEnumerable<Inspection>> GetByCustomerAndDateAsync(int customerId, DateTime inspectionDate);
        Task<Inspection> AddAsync(Inspection inspection);
        Task UpdateAsync(Inspection inspection);
        Task DeleteAsync(int id);
    }
}
