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

        public async Task<PlantHoldingReadDto> CreatePlantHoldingAsync(PlantHoldingDto holdingDto)
        {
            var holding = new PlantHolding
            {
                CustID = holdingDto.CustID,
                PlantNameID = holdingDto.PlantNameID,
                SerialNumber = holdingDto.SerialNumber,
                StatusID = holdingDto.StatusID,
                SWL = holdingDto.SWL
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
                SWL = holdingDto.SWL
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
                CustomerEmail = holding.Customer?.Email
            };
        }
    }
}
