using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using sky_webapi.Data.Entities;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Collections.Generic;
using sky_webapi.DTOs;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClaimsController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public ClaimsController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<ClaimDto>>> GetUserClaims(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return NotFound();
            var claims = await _userManager.GetClaimsAsync(user);
            var result = new List<ClaimDto>();
            foreach (var claim in claims)
            {
                result.Add(new ClaimDto { Type = claim.Type, Value = claim.Value });
            }
            return Ok(result);
        }
    }
}