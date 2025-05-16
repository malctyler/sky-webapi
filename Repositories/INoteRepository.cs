using sky_webapi.Data.Entities;

namespace sky_webapi.Repositories
{
    public interface INoteRepository
    {
        Task<IEnumerable<NoteEntity>> GetNotesAsync();
        Task<NoteEntity?> GetNoteAsync(int id);
        Task AddNoteAsync(NoteEntity note);
        Task UpdateNoteAsync(NoteEntity note);
        Task DeleteNoteAsync(int id);
        Task<bool> NoteExistsAsync(int id);
        Task<IEnumerable<NoteEntity>> GetNotesByCustomerIdAsync(int customerId);
    }
}
