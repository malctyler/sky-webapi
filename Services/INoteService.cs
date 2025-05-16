using sky_webapi.DTOs;

namespace sky_webapi.Services
{
    public interface INoteService
    {
        Task<IEnumerable<NoteDto>> GetAllNotesAsync();
        Task<NoteDto?> GetNoteByIdAsync(int id);
        Task<NoteDto> CreateNoteAsync(NoteDto noteDto);
        Task<NoteDto?> UpdateNoteAsync(int id, NoteDto noteDto);
        Task DeleteNoteAsync(int id);
        Task<IEnumerable<NoteDto>> GetNotesByCustomerIdAsync(int customerId);
    }
}
