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

        [HttpGet("{id}")]
        public async Task<ActionResult<RoleDto>> GetRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null) return NotFound();
            return Ok(new RoleDto { Id = role.Id, Name = role.Name });
        }

        [HttpPost]
        public async Task<ActionResult<RoleDto>> CreateRole([FromBody] RoleDto model)
        {
            var role = new IdentityRole(model.Name);
            var result = await _roleManager.CreateAsync(role);
            if (!result.Succeeded)
                return BadRequest(result.Errors);
            return CreatedAtAction(nameof(GetRole), new { id = role.Id }, new RoleDto { Id = role.Id, Name = role.Name });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRole(string id, [FromBody] RoleDto model)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null) return NotFound();
            role.Name = model.Name;
            var result = await _roleManager.UpdateAsync(role);
            if (!result.Succeeded)
                return BadRequest(result.Errors);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null) return NotFound();
            var result = await _roleManager.DeleteAsync(role);
            if (!result.Succeeded)
                return BadRequest(result.Errors);
            return NoContent();
        }
    }
}