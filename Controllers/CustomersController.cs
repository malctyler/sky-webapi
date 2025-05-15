using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using sky_webapi.DTOs;
using sky_webapi.Services;

namespace sky_webapi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        private bool IsCustomer()
        {
            return User.HasClaim("IsCustomer", "True");
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetCustomers()
        {
            if (IsCustomer())
            {
                return Forbid();
            }
            var customers = await _customerService.GetAllCustomersAsync();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDto>> GetCustomer(int id)
        {
            if (IsCustomer())
            {
                return Forbid();
            }
            var customer = await _customerService.GetCustomerByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult<CustomerDto>> CreateCustomer(CustomerDto customerDto)
        {
            if (IsCustomer())
            {
                return Forbid();
            }
            var createdCustomer = await _customerService.CreateCustomerAsync(customerDto);
            return CreatedAtAction(nameof(GetCustomer), new { id = createdCustomer.CustID }, createdCustomer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (IsCustomer())
            {
                return Forbid();
            }
            var updatedCustomer = await _customerService.UpdateCustomerAsync(id, customerDto);
            if (updatedCustomer == null)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            if (IsCustomer())
            {
                return Forbid();
            }
            await _customerService.DeleteCustomerAsync(id);
            return NoContent();
        }
    }
}
