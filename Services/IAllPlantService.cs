using sky_webapi.DTOs;

namespace sky_webapi.Services
{
    public interface IAllplantervice
    {
        Task<IEnumerable<AllPlantDto>> GetAllplantAsync();
        Task<AllPlantDto?> GetPlantByIdAsync(int id);
        Task<IEnumerable<AllPlantDto>> GetplantByCategoryAsync(int categoryId);
        Task<AllPlantDto> CreatePlantAsync(AllPlantDto plantDto);
        Task UpdatePlantAsync(int id, AllPlantDto plantDto);
        Task DeletePlantAsync(int id);
    }
}
