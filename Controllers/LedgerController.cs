using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sky_webapi.Data;
using sky_webapi.Data.Entities;
using sky_webapi.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sky_webapi.Controllers
{
    [Authorize(Roles = "Admin")]
    [ApiController]
    [Route("api/[controller]")]
    public class LedgerController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LedgerController(AppDbContext context)
        {
            _context = context;
        }        // GET: api/Ledger
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LedgerDto>>> GetLedgers([FromQuery] DateTime? startDate = null, [FromQuery] DateTime? endDate = null, [FromQuery] string? customerName = null)
        {
            var query = _context.Ledgers.AsQueryable();

            if (startDate.HasValue)
            {
                query = query.Where(l => l.InvoiceDate.Date >= startDate.Value.Date);
            }

            if (endDate.HasValue)
            {
                query = query.Where(l => l.InvoiceDate.Date <= endDate.Value.Date);
            }            if (!string.IsNullOrWhiteSpace(customerName))
            {
                query = query.Where(l => EF.Functions.Like(l.CustomerName.ToLower(), $"%{customerName.ToLower()}%"));
            }

            var ledgers = await query
                .Select(l => new LedgerDto
                {
                    Id = l.Id,
                    InvoiceDate = l.InvoiceDate,
                    CustomerName = l.CustomerName,
                    InvoiceRef = l.InvoiceRef,
                    SubTotal = l.SubTotal,
                    VAT = l.VAT,
                    Total = l.Total,
                    Settled = l.Settled
                })
                .ToListAsync();

            return Ok(ledgers);
        }

        // GET: api/Ledger/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LedgerDto>> GetLedger(int id)
        {
            var ledger = await _context.Ledgers.FindAsync(id);

            if (ledger == null)
            {
                return NotFound();
            }

            var ledgerDto = new LedgerDto
            {
                Id = ledger.Id,
                InvoiceDate = ledger.InvoiceDate,
                CustomerName = ledger.CustomerName,
                InvoiceRef = ledger.InvoiceRef,
                SubTotal = ledger.SubTotal,
                VAT = ledger.VAT,
                Total = ledger.Total,
                Settled = ledger.Settled
            };

            return Ok(ledgerDto);
        }

        // POST: api/Ledger
        [HttpPost]
        public async Task<ActionResult<LedgerDto>> CreateLedger(CreateUpdateLedgerDto createLedgerDto)
        {
            try
            {
                var ledger = new Ledger
                {
                    InvoiceDate = createLedgerDto.InvoiceDate,
                    CustomerName = createLedgerDto.CustomerName,
                    InvoiceRef = createLedgerDto.InvoiceRef,
                    SubTotal = createLedgerDto.SubTotal,
                    VAT = createLedgerDto.VAT,
                    Total = createLedgerDto.Total,
                    Settled = createLedgerDto.Settled
                };

                _context.Ledgers.Add(ledger);
                await _context.SaveChangesAsync();

                var ledgerDto = new LedgerDto
                {
                    Id = ledger.Id,
                    InvoiceDate = ledger.InvoiceDate,
                    CustomerName = ledger.CustomerName,
                    InvoiceRef = ledger.InvoiceRef,
                    SubTotal = ledger.SubTotal,
                    VAT = ledger.VAT,
                    Total = ledger.Total,
                    Settled = ledger.Settled
                };

                return CreatedAtAction(nameof(GetLedger), new { id = ledger.Id }, ledgerDto);
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException?.Message.Contains("IX_Ledgers_ReferenceWithoutInitials") == true)
                {
                    return BadRequest(new { message = "An invoice with this reference pattern already exists (ignoring initials)." });
                }
                throw;
            }
        }

        // PUT: api/Ledger/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLedger(int id, CreateUpdateLedgerDto updateLedgerDto)
        {
            var ledger = await _context.Ledgers.FindAsync(id);
            if (ledger == null)
            {
                return NotFound();
            }

            ledger.InvoiceDate = updateLedgerDto.InvoiceDate;
            ledger.CustomerName = updateLedgerDto.CustomerName;
            ledger.InvoiceRef = updateLedgerDto.InvoiceRef;
            ledger.SubTotal = updateLedgerDto.SubTotal;
            ledger.VAT = updateLedgerDto.VAT;
            ledger.Total = updateLedgerDto.Total;
            ledger.Settled = updateLedgerDto.Settled;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LedgerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Ledger/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLedger(int id)
        {
            var ledger = await _context.Ledgers.FindAsync(id);
            if (ledger == null)
            {
                return NotFound();
            }

            _context.Ledgers.Remove(ledger);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // PUT: api/Ledger/{id}/settle
        [HttpPut("{id}/settle")]
        public async Task<IActionResult> SettleLedger(int id)
        {
            var ledger = await _context.Ledgers.FindAsync(id);

            if (ledger == null)
            {
                return NotFound();
            }

            ledger.Settled = true;
            await _context.SaveChangesAsync();

            var ledgerDto = new LedgerDto
            {
                Id = ledger.Id,
                InvoiceDate = ledger.InvoiceDate,
                CustomerName = ledger.CustomerName,
                InvoiceRef = ledger.InvoiceRef,
                SubTotal = ledger.SubTotal,
                VAT = ledger.VAT,
                Total = ledger.Total,
                Settled = ledger.Settled
            };

            return Ok(ledgerDto);
        }

        // PUT: api/Ledger/{id}/unsettle
        [HttpPut("{id}/unsettle")]
        public async Task<IActionResult> UnsettleLedger(int id)
        {
            var ledger = await _context.Ledgers.FindAsync(id);

            if (ledger == null)
            {
                return NotFound();
            }

            ledger.Settled = false;
            await _context.SaveChangesAsync();

            var ledgerDto = new LedgerDto
            {
                Id = ledger.Id,
                InvoiceDate = ledger.InvoiceDate,
                CustomerName = ledger.CustomerName,
                InvoiceRef = ledger.InvoiceRef,
                SubTotal = ledger.SubTotal,
                VAT = ledger.VAT,
                Total = ledger.Total,
                Settled = ledger.Settled
            };

            return Ok(ledgerDto);
        }

        private bool LedgerExists(int id)
        {
            return _context.Ledgers.Any(e => e.Id == id);
        }
    }
}
