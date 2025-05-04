using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using sky_webapi.Data.Entities;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Collections.Generic;
using sky_webapi.DTOs;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Staff")] // Only staff should manage claims
    public class ClaimsController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<ClaimsController> _logger;

        public ClaimsController(UserManager<ApplicationUser> userManager, ILogger<ClaimsController> logger)
        {
            _userManager = userManager;
            _logger = logger;
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

        [HttpGet("{userId}/claims/{type}")]
        public async Task<ActionResult<ClaimDto>> GetUserClaim(string userId, string type)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return NotFound();
            var claims = await _userManager.GetClaimsAsync(user);
            var claim = claims.FirstOrDefault(c => c.Type == type);
            if (claim == null) return NotFound();
            return Ok(new ClaimDto { Type = claim.Type, Value = claim.Value });
        }

        [HttpPost("{userId}/claims")]
        public async Task<IActionResult> AddClaim(string userId, [FromBody] ClaimDto model)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(model.Type) || string.IsNullOrWhiteSpace(model.Value))
                {
                    _logger.LogWarning("Attempt to add claim with empty type or value for user {UserId}", userId);
                    return BadRequest("Claim type and value cannot be empty");
                }

                var user = await _userManager.FindByIdAsync(userId);
                if (user == null)
                {
                    _logger.LogWarning("Attempt to add claim for non-existent user {UserId}", userId);
                    return NotFound("User not found");
                }

                // Check if claim already exists
                var existingClaims = await _userManager.GetClaimsAsync(user);
                if (existingClaims.Any(c => c.Type == model.Type))
                {
                    _logger.LogWarning("Attempt to add duplicate claim type {ClaimType} for user {UserId}", model.Type, userId);
                    return BadRequest($"User already has a claim of type '{model.Type}'");
                }

                var result = await _userManager.AddClaimAsync(user, new Claim(model.Type, model.Value));
                if (!result.Succeeded)
                {
                    var errors = result.Errors.Select(e => e.Description);
                    _logger.LogError("Failed to add claim {ClaimType} for user {UserId}. Errors: {Errors}", 
                        model.Type, userId, string.Join(", ", errors));
                    return BadRequest(result.Errors);
                }

                _logger.LogInformation("Successfully added claim {ClaimType} for user {UserId}", model.Type, userId);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding claim {ClaimType} for user {UserId}", model?.Type ?? "unknown", userId);
                return StatusCode(500, "An error occurred while adding the claim");
            }
        }

        [HttpPut("{userId}/claims/{type}")]
        public async Task<IActionResult> UpdateClaim(string userId, string type, [FromBody] ClaimDto model)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return NotFound();
            var claims = await _userManager.GetClaimsAsync(user);
            var oldClaim = claims.FirstOrDefault(c => c.Type == type);
            if (oldClaim == null) return NotFound();
            var resultRemove = await _userManager.RemoveClaimAsync(user, oldClaim);
            if (!resultRemove.Succeeded)
                return BadRequest(resultRemove.Errors);
            var resultAdd = await _userManager.AddClaimAsync(user, new System.Security.Claims.Claim(model.Type, model.Value));
            if (!resultAdd.Succeeded)
                return BadRequest(resultAdd.Errors);
            return NoContent();
        }

        [HttpDelete("{userId}/claims/{type}")]
        public async Task<IActionResult> DeleteClaim(string userId, string type)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return NotFound();
            var claims = await _userManager.GetClaimsAsync(user);
            var claim = claims.FirstOrDefault(c => c.Type == type);
            if (claim == null) return NotFound();
            var result = await _userManager.RemoveClaimAsync(user, claim);
            if (!result.Succeeded)
                return BadRequest(result.Errors);
            return NoContent();
        }
    }
}