using sky_webapi.DTOs;

namespace sky_webapi.Services
{
    public class MultiInspectionService : IMultiInspectionService
    {
        private readonly IPlantHoldingService _plantHoldingService;
        private readonly IInspectionService _inspectionService;

        public MultiInspectionService(
            IPlantHoldingService plantHoldingService,
            IInspectionService inspectionService)
        {
            _plantHoldingService = plantHoldingService;
            _inspectionService = inspectionService;
        }

        public async Task<IEnumerable<MultiInspectionItemDto>> GetMultiInspectionItemsAsync(int customerId, int[] categoryIds)
        {
            return await _plantHoldingService.GetPlantHoldingsByCustomerAndCategoriesAsync(customerId, categoryIds);
        }

        public async Task<IEnumerable<PlantCategoryDto>> GetCategoriesWithHoldingsByCustomerAsync(int customerId)
        {
            return await _plantHoldingService.GetCategoriesWithHoldingsByCustomerAsync(customerId);
        }

        public async Task<IEnumerable<InspectionReadDto>> CreateMultiInspectionAsync(CreateMultiInspectionDto createDto)
        {
            var createdInspections = new List<InspectionReadDto>();

            // Filter only included items
            var includedItems = createDto.Items.Where(item => item.Included).ToArray();

            foreach (var item in includedItems)
            {
                var inspectionDto = new CreateUpdateInspectionDto
                {
                    HoldingID = item.HoldingID,
                    InspectionDate = createDto.InspectionDate,
                    Location = createDto.Location,
                    RecentCheck = item.RecentCheck,
                    PreviousCheck = item.PreviousCheck,
                    SafeWorking = item.SafeWorking,
                    Defects = item.Defects,
                    Rectified = item.Rectified,
                    LatestDate = createDto.LatestDate, // Now optional - will be null if not provided
                    TestDetails = createDto.TestDetails,
                    MiscNotes = createDto.MiscNotes,
                    InspectorID = createDto.InspectorID
                };

                var createdInspection = await _inspectionService.CreateInspectionAsync(inspectionDto);
                createdInspections.Add(createdInspection);
            }

            return createdInspections;
        }

        public async Task<IEnumerable<InspectionReadDto>> GetCompletedMultiInspectionsAsync(int customerId, string inspectionDate)
        {
            // Parse the inspection date
            if (!DateTime.TryParse(inspectionDate, out DateTime parsedDate))
            {
                throw new ArgumentException("Invalid date format. Expected YYYY-MM-DD format.");
            }

            // Get all inspections for the customer on the specified date
            // We'll delegate to the inspection service to get inspections by customer and date
            return await _inspectionService.GetInspectionsByCustomerAndDateAsync(customerId, parsedDate);
        }
    }
}
