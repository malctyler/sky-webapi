using sky_webapi.DTOs;

namespace sky_webapi.Services
{
    public interface IPlantHoldingService
    {
        Task<IEnumerable<PlantHoldingReadDto>> GetAllPlantHoldingsAsync();
        Task<PlantHoldingReadDto?> GetPlantHoldingByIdAsync(int id);
        Task<IEnumerable<PlantHoldingReadDto>> GetPlantHoldingsByCustomerIdAsync(int customerId);
        Task<PlantHoldingReadDto> CreatePlantHoldingAsync(PlantHoldingDto holdingDto);
        Task<PlantHoldingReadDto> UpdatePlantHoldingAsync(int id, PlantHoldingDto holdingDto);
        Task DeletePlantHoldingAsync(int id);
        Task<IEnumerable<PlantHoldingReadDto>> GetPlantHoldingsByStatusAsync(int statusId);
        Task<IEnumerable<PlantHoldingReadDto>> GetPlantHoldingsByCustomerAndStatusAsync(int customerId, int statusId);
    }
}
