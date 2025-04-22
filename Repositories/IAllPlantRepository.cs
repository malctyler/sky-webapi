using sky_webapi.Data.Entities;

namespace sky_webapi.Repositories
{
    public interface IAllPlantRepository
    {
        Task<IEnumerable<AllPlantEntity>> GetAllAsync();
        Task<AllPlantEntity?> GetByIdAsync(int id);
        Task<IEnumerable<AllPlantEntity>> GetByCategoryAsync(int categoryId);
        Task<AllPlantEntity> AddAsync(AllPlantEntity plant);
        Task UpdateAsync(AllPlantEntity plant);
        Task DeleteAsync(int id);
    }
}
