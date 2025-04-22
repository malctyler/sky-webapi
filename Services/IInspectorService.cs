using sky_webapi.DTOs;

namespace sky_webapi.Services
{
    public interface IInspectorService
    {
        Task<IEnumerable<InspectorDto>> GetAllInspectorsAsync();
        Task<InspectorDto?> GetInspectorByIdAsync(int id);
        Task<InspectorDto> CreateInspectorAsync(InspectorDto inspectorDto);
        Task<InspectorDto> UpdateInspectorAsync(int id, InspectorDto inspectorDto);
        Task DeleteInspectorAsync(int id);
    }
}
