using Microsoft.EntityFrameworkCore;
using sky_webapi.Data;
using sky_webapi.Data.Entities;

namespace sky_webapi.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly AppDbContext _context;

        public NoteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<NoteEntity>> GetNotesAsync()
        {
            return await _context.Notes.ToListAsync();
        }

        public async Task<NoteEntity?> GetNoteAsync(int id)
        {
            return await _context.Notes.FindAsync(id);
        }

        public async Task AddNoteAsync(NoteEntity note)
        {
            _context.Notes.Add(note);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateNoteAsync(NoteEntity note)
        {
            _context.Entry(note).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteNoteAsync(int id)
        {
            var note = await _context.Notes.FindAsync(id);
            if (note != null)
            {
                _context.Notes.Remove(note);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> NoteExistsAsync(int id)
        {
            return await _context.Notes.AnyAsync(e => e.NoteID == id);
        }

        public async Task<IEnumerable<NoteEntity>> GetNotesByCustomerIdAsync(int customerId)
        {
            return await _context.Notes
                .Where(n => n.CustID == customerId)
                .OrderByDescending(n => n.Date)
                .ToListAsync();
        }
    }
}
