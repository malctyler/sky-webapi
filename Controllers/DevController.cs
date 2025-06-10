using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sky_webapi.Data;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "Admin")]
    public class DevController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DevController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("update-postcodes")]
        public IActionResult UpdatePostcodes()
        {
            if (!HttpContext.RequestServices.GetService<IWebHostEnvironment>()!.IsDevelopment())
            {
                return NotFound();
            }

            DatabaseSeeder.UpdateCustomerPostcodes(_context);
            return Ok(new { message = "Customer postcodes updated successfully" });
        }
    }
}
