using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using sky_webapi.Data.Entities;
using sky_webapi.DTOs;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")] // Only admin can manage users
    public class UsersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<UsersController> _logger;

        public UsersController(
            UserManager<ApplicationUser> userManager,
            ILogger<UsersController> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
        {
            var users = _userManager.Users;
            var result = new List<UserDto>();
            foreach (var user in users)
            {
                result.Add(new UserDto
                {
                    Id = user.Id,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    IsCustomer = user.IsCustomer,
                    CustomerId = user.CustomerId,
                    EmailConfirmed = user.EmailConfirmed // Added
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
                Id = user.Id,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                IsCustomer = user.IsCustomer,
                CustomerId = user.CustomerId,
                EmailConfirmed = user.EmailConfirmed // Added
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
                EmailConfirmed = model.EmailConfirmed // Set the email confirmed status
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return BadRequest(result.Errors);

            // Add IsCustomer claim with lowercase boolean value to ensure consistency
            await _userManager.AddClaimAsync(user, new System.Security.Claims.Claim("IsCustomer", model.IsCustomer.ToString().ToLower()));

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
            
            // Only allow staff to update email confirmation status
            if (User.IsInRole("Staff") && user.EmailConfirmed != model.EmailConfirmed)
            {
                user.EmailConfirmed = model.EmailConfirmed;
                _logger.LogInformation("Email confirmation status updated for user {Email} to {Status} by staff member", 
                    user.Email, model.EmailConfirmed);
            }

            // Email and username update omitted for safety
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

        // Add endpoint to get user roles
        [HttpGet("{id}/roles")]
        public async Task<ActionResult<IEnumerable<string>>> GetUserRoles(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            var roles = await _userManager.GetRolesAsync(user);
            return Ok(roles);
        }

        [HttpPost("{id}/roles")]
        public async Task<IActionResult> AddUserToRole(string id, [FromBody] RoleAssignmentDto model)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound("User not found");

            if (string.IsNullOrWhiteSpace(model.RoleName))
                return BadRequest("Role name must be provided");

            var result = await _userManager.AddToRoleAsync(user, model.RoleName);
            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return NoContent();
        }

        [HttpDelete("{id}/roles/{roleName}")]
        public async Task<IActionResult> RemoveUserFromRole(string id, string roleName)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound("User not found");

            if (string.IsNullOrWhiteSpace(roleName))
                return BadRequest("Role name must be provided");

            var result = await _userManager.RemoveFromRoleAsync(user, roleName);
            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return NoContent();
        }
    }
}