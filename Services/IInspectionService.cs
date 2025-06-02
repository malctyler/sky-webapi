using sky_webapi.DTOs;

namespace sky_webapi.Services
{
    public interface IInspectionService
    {
        Task<IEnumerable<InspectionReadDto>> GetAllInspectionsAsync();
        Task<InspectionReadDto?> GetInspectionByIdAsync(int id);
        Task<IEnumerable<InspectionReadDto>> GetInspectionsByPlantHoldingAsync(int holdingId);        Task<InspectionReadDto> CreateInspectionAsync(CreateUpdateInspectionDto createDto);
        Task<InspectionReadDto> UpdateInspectionAsync(int id, CreateUpdateInspectionDto updateDto);
        Task DeleteInspectionAsync(int id);
    }
}
