using Microsoft.AspNetCore.Mvc;
using sky_webapi.DTOs;
using sky_webapi.Services;

namespace sky_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INoteService _noteService;

        public NotesController(INoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<NoteDto>>> GetNotes()
        {
            var notes = await _noteService.GetAllNotesAsync();
            return Ok(notes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NoteDto>> GetNote(int id)
        {
            var note = await _noteService.GetNoteByIdAsync(id);
            if (note == null)
            {
                return NotFound();
            }
            return Ok(note);
        }

        [HttpGet("customer/{customerId}")]
        public async Task<ActionResult<IEnumerable<NoteDto>>> GetNotesByCustomer(int customerId)
        {
            var notes = await _noteService.GetNotesByCustomerIdAsync(customerId);
            return Ok(notes);
        }

        [HttpPost]
        public async Task<ActionResult<NoteDto>> CreateNote(NoteDto noteDto)
        {
            var createdNote = await _noteService.CreateNoteAsync(noteDto);
            return CreatedAtAction(nameof(GetNote), new { id = createdNote.NoteID }, createdNote);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNote(int id, NoteDto noteDto)
        {
            var updatedNote = await _noteService.UpdateNoteAsync(id, noteDto);
            if (updatedNote == null)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNote(int id)
        {
            await _noteService.DeleteNoteAsync(id);
            return NoContent();
        }
    }
}
