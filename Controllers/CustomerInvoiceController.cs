using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sky_webapi.DTOs;
using sky_webapi.Exceptions;
using sky_webapi.Services;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("api/customers")]
    [Authorize(Roles = "Admin")]
    public class CustomerInvoiceController : ControllerBase
    {
        private readonly ICustomerInvoiceService _invoiceService;

        public CustomerInvoiceController(ICustomerInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        /// <summary>
        /// Generates invoice data for a customer within the specified date range
        /// </summary>
        /// <param name="customerId">The ID of the customer</param>
        /// <param name="startDate">Start date for the invoice period</param>
        /// <param name="endDate">End date for the invoice period</param>
        /// <returns>Customer invoice data including inspection line items</returns>
        /// <response code="200">Returns the invoice data</response>
        /// <response code="400">If the date range is invalid</response>
        /// <response code="404">If the customer is not found</response>
        [HttpGet("{customerId}/invoices")]
        [ProducesResponseType(typeof(CustomerInvoiceDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<CustomerInvoiceDto>> GetCustomerInvoice(
            int customerId,
            [FromQuery] DateTime startDate,
            [FromQuery] DateTime endDate)
        {
            try
            {
                var invoiceData = await _invoiceService.GetCustomerInvoiceDataAsync(customerId, startDate, endDate);
                return Ok(invoiceData);
            }
            catch (BadRequestException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
