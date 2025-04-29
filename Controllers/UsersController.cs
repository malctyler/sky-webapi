using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using sky_webapi.Data.Entities;
using sky_webapi.DTOs;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public UsersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
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
                    CustomerId = user.CustomerId
                });
            }
            return Ok(result);
        }
    }
}