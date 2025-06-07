using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Linq;
using sky_webapi.DTOs;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Staff")] // Only staff should manage roles
    public class RolesController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<RolesController> _logger;

        public RolesController(RoleManager<IdentityRole> roleManager, ILogger<RolesController> logger)
        {
            _roleManager = roleManager;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<RoleDto>> GetRoles()
        {
            var roles = _roleManager.Roles;
            var result = new List<RoleDto>();
            foreach (var role in roles)
            {
                result.Add(new RoleDto { Id = role.Id ?? "", Name = role.Name ?? "" });
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RoleDto>> GetRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null) return NotFound();
            return Ok(new RoleDto { Id = role.Id ?? "", Name = role.Name ?? "" });
        }

        [HttpPost]
        public async Task<ActionResult<RoleDto>> CreateRole([FromBody] RoleDto model)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(model.Name))
                {
                    _logger.LogWarning("Attempted to create role with empty name");
                    return BadRequest("Role name cannot be empty");
                }

                // Normalize the role name
                model.Name = model.Name.Trim();

                // Check if role already exists
                if (await _roleManager.RoleExistsAsync(model.Name))
                {
                    _logger.LogWarning("Attempted to create duplicate role: {RoleName}", model.Name);
                    return BadRequest($"Role '{model.Name}' already exists");
                }

                var role = new IdentityRole(model.Name);
                var result = await _roleManager.CreateAsync(role);
                
                if (!result.Succeeded)
                {
                    _logger.LogError("Failed to create role {RoleName}. Errors: {Errors}", 
                        model.Name, string.Join(", ", result.Errors.Select(e => e.Description)));
                    return BadRequest(result.Errors);
                }

                _logger.LogInformation("Successfully created role: {RoleName}", model.Name);
                return CreatedAtAction(nameof(GetRole), new { id = role.Id }, 
                    new RoleDto { Id = role.Id ?? "", Name = role.Name ?? "" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating role {RoleName}", model?.Name ?? "unknown");
                return StatusCode(500, "An error occurred while creating the role");
            }
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