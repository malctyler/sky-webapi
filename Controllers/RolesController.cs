using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Collections.Generic;
using sky_webapi.DTOs;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [HttpGet]
        public ActionResult<IEnumerable<RoleDto>> GetRoles()
        {
            var roles = _roleManager.Roles;
            var result = new List<RoleDto>();
            foreach (var role in roles)
            {
                result.Add(new RoleDto { Id = role.Id, Name = role.Name });
            }
            return Ok(result);
        }
    }
}