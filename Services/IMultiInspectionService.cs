using sky_webapi.DTOs;

namespace sky_webapi.Services
{
    public interface IMultiInspectionService
    {
        Task<IEnumerable<MultiInspectionItemDto>> GetMultiInspectionItemsAsync(int customerId, int[] categoryIds);
        Task<IEnumerable<InspectionReadDto>> CreateMultiInspectionAsync(CreateMultiInspectionDto createDto);
        Task<IEnumerable<PlantCategoryDto>> GetCategoriesWithHoldingsByCustomerAsync(int customerId);
        Task<IEnumerable<InspectionReadDto>> GetCompletedMultiInspectionsAsync(int customerId, string inspectionDate);
    }
}
