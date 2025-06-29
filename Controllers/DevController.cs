using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sky_webapi.Data;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "Admin")] // Restored for security
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

        [HttpPost("clear-entity-data")]
        [Authorize(Roles = "Admin")] // Require admin authorization
        public async Task<IActionResult> ClearEntityData()
        {
            if (!HttpContext.RequestServices.GetService<IWebHostEnvironment>()!.IsDevelopment())
            {
                return NotFound();
            }

            try
            {
                await DatabaseSeeder.ClearCustomEntityData(_context);
                return Ok(new { message = "All custom entity data cleared successfully. ASP.NET Identity tables preserved." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = "Failed to clear data", details = ex.Message });
            }
        }
    }
}
