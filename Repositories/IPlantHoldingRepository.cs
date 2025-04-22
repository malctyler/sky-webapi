using sky_webapi.Data.Entities;

namespace sky_webapi.Repositories
{
    public interface IPlantHoldingRepository
    {
        Task<IEnumerable<PlantHolding>> GetAllAsync();
        Task<PlantHolding?> GetByIdAsync(int id);
        Task<IEnumerable<PlantHolding>> GetByCustomerAsync(int customerId);
        Task<IEnumerable<PlantHolding>> GetByStatusAsync(int statusId);
        Task<PlantHolding> AddAsync(PlantHolding plantHolding);
        Task UpdateAsync(PlantHolding plantHolding);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
