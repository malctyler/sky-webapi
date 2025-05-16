using sky_webapi.DTOs;
using sky_webapi.Data.Entities;
using sky_webapi.Repositories;

namespace sky_webapi.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;

        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public async Task<IEnumerable<NoteDto>> GetAllNotesAsync()
        {
            var notes = await _noteRepository.GetNotesAsync();
            return notes.Select(n => new NoteDto
            {
                NoteID = n.NoteID,
                CustID = n.CustID,
                Date = n.Date,
                Notes = n.Notes
            });
        }

        public async Task<NoteDto?> GetNoteByIdAsync(int id)
        {
            var note = await _noteRepository.GetNoteAsync(id);
            if (note == null)
            {
                return null;
            }

            return new NoteDto
            {
                NoteID = note.NoteID,
                CustID = note.CustID,
                Date = note.Date,
                Notes = note.Notes
            };
        }

        public async Task<NoteDto> CreateNoteAsync(NoteDto noteDto)
        {
            var note = new NoteEntity
            {
                CustID = noteDto.CustID,
                Date = noteDto.Date,
                Notes = noteDto.Notes
            };

            await _noteRepository.AddNoteAsync(note);

            noteDto.NoteID = note.NoteID;
            return noteDto;
        }

        public async Task<NoteDto?> UpdateNoteAsync(int id, NoteDto noteDto)
        {
            var note = await _noteRepository.GetNoteAsync(id);
            if (note == null)
            {
                return null;
            }

            note.CustID = noteDto.CustID;
            note.Date = noteDto.Date;
            note.Notes = noteDto.Notes;

            await _noteRepository.UpdateNoteAsync(note);

            return noteDto;
        }

        public async Task DeleteNoteAsync(int id)
        {
            await _noteRepository.DeleteNoteAsync(id);
        }

        public async Task<IEnumerable<NoteDto>> GetNotesByCustomerIdAsync(int customerId)
        {
            var notes = await _noteRepository.GetNotesByCustomerIdAsync(customerId);
            return notes.Select(n => new NoteDto
            {
                NoteID = n.NoteID,
                CustID = n.CustID,
                Date = n.Date,
                Notes = n.Notes
            });
        }
    }
}
