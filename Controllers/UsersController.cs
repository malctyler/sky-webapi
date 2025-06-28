using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using sky_webapi.Data.Entities;
using sky_webapi.DTOs;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")] // Only admin can manage users
    public class UsersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<UsersController> _logger;

        public UsersController(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ILogger<UsersController> logger)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserDto>> GetUsers()
        {
            var users = _userManager.Users;
            var result = new List<UserDto>();
            foreach (var user in users)
            {
                result.Add(new UserDto
                {
                    Id = user.Id ?? "",
                    Email = user.Email ?? "",
                    FirstName = user.FirstName ?? "",
                    LastName = user.LastName ?? "",
                    IsCustomer = user.IsCustomer,
                    CustomerId = user.CustomerId,
                    EmailConfirmed = user.EmailConfirmed
                });
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            return Ok(new UserDto
            {
                Id = user.Id ?? "",
                Email = user.Email ?? "",
                FirstName = user.FirstName ?? "",
                LastName = user.LastName ?? "",
                IsCustomer = user.IsCustomer,
                CustomerId = user.CustomerId,
                EmailConfirmed = user.EmailConfirmed
            });
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> CreateUser([FromBody] RegisterDto model)
        {
            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                IsCustomer = model.IsCustomer,
                CustomerId = model.CustomerId,
                EmailConfirmed = model.EmailConfirmed
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                IsCustomer = user.IsCustomer,
                CustomerId = user.CustomerId,
                EmailConfirmed = user.EmailConfirmed
            });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(string id, [FromBody] UserDto model)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.IsCustomer = model.IsCustomer;
            user.CustomerId = model.CustomerId;
            
            if (User.IsInRole("Staff") && user.EmailConfirmed != model.EmailConfirmed)
            {
                user.EmailConfirmed = model.EmailConfirmed;
                _logger.LogInformation("Email confirmation status updated for user {Email} to {Status} by staff member", 
                    user.Email, model.EmailConfirmed);
            }

            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
                return BadRequest(result.Errors);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            var result = await _userManager.DeleteAsync(user);
            if (!result.Succeeded)
                return BadRequest(result.Errors);
            return NoContent();
        }

        [HttpGet("{id}/roles")]
        public async Task<ActionResult<IEnumerable<RoleDto>>> GetUserRoles(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound($"User with ID {id} not found");
            }

            var roleNames = await _userManager.GetRolesAsync(user);
            var roleDtos = new List<RoleDto>();

            foreach (var roleName in roleNames)
            {
                var role = await _roleManager.FindByNameAsync(roleName);
                if (role?.Id != null && role.Name != null)
                {
                    roleDtos.Add(new RoleDto { Id = role.Id, Name = role.Name });
                }
            }

            return Ok(roleDtos);
        }

        [HttpPost("{id}/roles/{roleId}")]
        public async Task<IActionResult> AssignRole(string id, string roleId)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound($"User with ID {id} not found");
            }

            var role = await _roleManager.FindByIdAsync(roleId);
            if (role?.Name == null)
            {
                return NotFound($"Role with ID {roleId} not found");
            }

            if (await _userManager.IsInRoleAsync(user, role.Name))
            {
                return BadRequest($"User is already in role {role.Name}");
            }

            var result = await _userManager.AddToRoleAsync(user, role.Name);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return NoContent();
        }

        [HttpDelete("{id}/roles/{roleId}")]
        public async Task<IActionResult> RemoveRole(string id, string roleId)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound($"User with ID {id} not found");
            }

            var role = await _roleManager.FindByIdAsync(roleId);
            if (role?.Name == null)
            {
                return NotFound($"Role with ID {roleId} not found");
            }

            if (!await _userManager.IsInRoleAsync(user, role.Name))
            {
                return BadRequest($"User is not in role {role.Name}");
            }

            var result = await _userManager.RemoveFromRoleAsync(user, role.Name);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return NoContent();
        }
    }
}