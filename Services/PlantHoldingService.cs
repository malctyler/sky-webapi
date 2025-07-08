using sky_webapi.DTOs;
using sky_webapi.Data.Entities;
using sky_webapi.Repositories;

namespace sky_webapi.Services
{
    public class PlantHoldingService : IPlantHoldingService
    {
        private readonly IPlantHoldingRepository _repository;

        public PlantHoldingService(IPlantHoldingRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<PlantHoldingReadDto>> GetAllPlantHoldingsAsync()
        {
            var holdings = await _repository.GetAllAsync();
            return holdings.Select(MapToReadDto);
        }

        public async Task<PlantHoldingReadDto?> GetPlantHoldingByIdAsync(int id)
        {
            var holding = await _repository.GetByIdAsync(id);
            return holding != null ? MapToReadDto(holding) : null;
        }

        public async Task<IEnumerable<PlantHoldingReadDto>> GetPlantHoldingsByCustomerIdAsync(int customerId)
        {
            var holdings = await _repository.GetByCustomerAsync(customerId);
            return holdings.Select(MapToReadDto);
        }

        public async Task<IEnumerable<PlantHoldingReadDto>> GetPlantHoldingsByStatusAsync(int statusId)
        {
            var holdings = await _repository.GetByStatusAsync(statusId);
            return holdings.Select(MapToReadDto);
        }

        public async Task<IEnumerable<PlantHoldingReadDto>> GetPlantHoldingsByCustomerAndStatusAsync(int customerId, int statusId)
        {
            var holdings = await _repository.GetByCustomerAndStatusAsync(customerId, statusId);
            return holdings.Select(MapToReadDto);
        }

        public async Task<PlantHoldingReadDto> CreatePlantHoldingAsync(PlantHoldingDto holdingDto)
        {
            var holding = new PlantHolding
            {
                CustID = holdingDto.CustID,
                PlantNameID = holdingDto.PlantNameID,
                SerialNumber = holdingDto.SerialNumber,
                StatusID = holdingDto.StatusID,
                SWL = holdingDto.SWL,
                InspectionFrequency = holdingDto.InspectionFrequency,
                InspectionFee = holdingDto.InspectionFee
            };

            var result = await _repository.AddAsync(holding);
            // Reload the entity with navigation properties
            var createdHolding = await _repository.GetByIdAsync(result.HoldingID);
            return MapToReadDto(createdHolding!);
        }

        public async Task<PlantHoldingReadDto> UpdatePlantHoldingAsync(int id, PlantHoldingDto holdingDto)
        {
            var holding = new PlantHolding
            {
                HoldingID = id,
                CustID = holdingDto.CustID,
                PlantNameID = holdingDto.PlantNameID,
                SerialNumber = holdingDto.SerialNumber,
                StatusID = holdingDto.StatusID,
                SWL = holdingDto.SWL,
                InspectionFrequency = holdingDto.InspectionFrequency,
                InspectionFee = holdingDto.InspectionFee
            };

            await _repository.UpdateAsync(holding);
            // Reload the entity with navigation properties
            var updatedHolding = await _repository.GetByIdAsync(id);
            return MapToReadDto(updatedHolding!);
        }

        public async Task DeletePlantHoldingAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<MultiInspectionItemDto>> GetPlantHoldingsByCustomerAndCategoriesAsync(int customerId, int[] categoryIds)
        {
            var holdings = await _repository.GetByCustomerAndCategoriesAsync(customerId, categoryIds);
            return holdings.Select(MapToMultiInspectionItemDto);
        }

        public async Task<IEnumerable<PlantCategoryDto>> GetCategoriesWithHoldingsByCustomerAsync(int customerId)
        {
            var categories = await _repository.GetCategoriesWithHoldingsByCustomerAsync(customerId);
            return categories.Select(MapToPlantCategoryDto);
        }

        private static PlantCategoryDto MapToPlantCategoryDto(PlantCategoryEntity category)
        {
            return new PlantCategoryDto
            {
                CategoryID = category.CategoryID,
                CategoryDescription = category.CategoryDescription,
                MultiInspect = category.MultiInspect
            };
        }

        private static MultiInspectionItemDto MapToMultiInspectionItemDto(PlantHolding holding)
        {
            return new MultiInspectionItemDto
            {
                HoldingID = holding.HoldingID,
                PlantDescription = holding.Plant?.PlantDescription,
                SerialNumber = holding.SerialNumber,
                SWL = holding.SWL,
                StatusDescription = holding.Status?.StatusDescription,
                Defects = "", // Default empty, will be filled by user
                Included = false, // Default false, user will select
                CustID = holding.CustID,
                CategoryDescription = holding.Plant?.Category?.CategoryDescription,
                StatusID = holding.StatusID
            };
        }

        private static PlantHoldingReadDto MapToReadDto(PlantHolding holding)
        {
            return new PlantHoldingReadDto
            {
                HoldingID = holding.HoldingID,
                CustID = holding.CustID,
                PlantNameID = holding.PlantNameID,
                SerialNumber = holding.SerialNumber,
                StatusID = holding.StatusID,
                SWL = holding.SWL,
                InspectionFrequency = holding.InspectionFrequency,
                InspectionFee = holding.InspectionFee,
                PlantDescription = holding.Plant?.PlantDescription,
                StatusDescription = holding.Status?.StatusDescription,
                CustomerCompanyName = holding.Customer?.CompanyName,
                CustomerContactTitle = holding.Customer?.ContactTitle,
                CustomerContactFirstNames = holding.Customer?.ContactFirstNames,
                CustomerContactSurname = holding.Customer?.ContactSurname,
                CustomerLine1 = holding.Customer?.Line1,
                CustomerLine2 = holding.Customer?.Line2,
                CustomerLine3 = holding.Customer?.Line3,
                CustomerLine4 = holding.Customer?.Line4,
                CustomerPostcode = holding.Customer?.Postcode,
                CustomerTelephone = holding.Customer?.Telephone,
                CustomerEmail = holding.Customer?.Email,
                MultiInspect = holding.Plant?.Category?.MultiInspect ?? false
            };
        }
    }
}
