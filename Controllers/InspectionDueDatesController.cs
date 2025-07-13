using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using sky_webapi.DTOs;
using sky_webapi.Services;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,Staff")] // Allow both Admin and Staff to access inspection due dates
    public class InspectionDueDatesController : ControllerBase
    {
        private readonly IInspectionDueDateService _service;

        public InspectionDueDatesController(IInspectionDueDateService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InspectionDueDateDto>>> GetInspectionDueDates()
        {
            var dueDates = await _service.GetAllInspectionDueDatesAsync();
            return Ok(dueDates);
        }
    }
}
