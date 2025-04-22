using sky_webapi.Data.Entities;
using sky_webapi.DTOs;
using sky_webapi.Repositories;

namespace sky_webapi.Services
{
    public class InspectorService : IInspectorService
    {
        private readonly IInspectorRepository _repository;

        public InspectorService(IInspectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<InspectorDto>> GetAllInspectorsAsync()
        {
            var inspectors = await _repository.GetAllAsync();
            return inspectors.Select(MapToDto);
        }

        public async Task<InspectorDto?> GetInspectorByIdAsync(int id)
        {
            var inspector = await _repository.GetByIdAsync(id);
            return inspector != null ? MapToDto(inspector) : null;
        }

        public async Task<InspectorDto> CreateInspectorAsync(InspectorDto inspectorDto)
        {
            var inspector = new InspectorEntity
            {
                InspectorsName = inspectorDto.InspectorsName
            };

            var result = await _repository.AddAsync(inspector);
            return MapToDto(result);
        }

        public async Task<InspectorDto> UpdateInspectorAsync(int id, InspectorDto inspectorDto)
        {
            var inspector = new InspectorEntity
            {
                InspectorID = id,
                InspectorsName = inspectorDto.InspectorsName
            };

            await _repository.UpdateAsync(inspector);
            var updatedInspector = await _repository.GetByIdAsync(id);
            return MapToDto(updatedInspector!);
        }

        public async Task DeleteInspectorAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        private static InspectorDto MapToDto(InspectorEntity inspector)
        {
            return new InspectorDto
            {
                InspectorID = inspector.InspectorID,
                InspectorsName = inspector.InspectorsName
            };
        }
    }
}
