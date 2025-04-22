using sky_webapi.DTOs;

namespace sky_webapi.Services
{
    public interface IStatusService
    {
        Task<IEnumerable<StatusDto>> GetAllStatusAsync();
        Task<StatusDto?> GetStatusByIdAsync(int id);
        Task<StatusDto> CreateStatusAsync(StatusDto statusDto);
        Task UpdateStatusAsync(int id, StatusDto statusDto);
        Task DeleteStatusAsync(int id);
    }
}
