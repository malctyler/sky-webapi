using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using sky_webapi.Data.Entities;
using System;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Collections.Generic;
using sky_webapi.DTOs;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using sky_webapi.Data;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Staff")]
    public class ClaimsController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<ClaimsController> _logger;
        private readonly AppDbContext _context;

        public ClaimsController(
            UserManager<ApplicationUser> userManager,
            ILogger<ClaimsController> logger,
            AppDbContext context)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<ClaimDto>>> GetUserClaims(string userId)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user == null)
                {
                    _logger.LogWarning("Attempted to get claims for non-existent user {UserId}", userId);
                    return NotFound("User not found");
                }
                var claims = await _userManager.GetClaimsAsync(user);
                var result = claims.Select(claim => new ClaimDto 
                { 
                    Type = claim.Type, 
                    Value = claim.Value 
                }).ToList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving claims for user {UserId}", userId);
                return StatusCode(500, "An error occurred while retrieving claims");
            }
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
                if (model == null)
                {
                    _logger.LogWarning("Attempt to add null claim for user {UserId}", userId);
                    return BadRequest("Claim data cannot be null");
                }

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
                return Ok(new ClaimDto { Type = model.Type, Value = model.Value });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding claim {ClaimType} for user {UserId}", model?.Type ?? "unknown", userId);
                return StatusCode(500, new { message = "An error occurred while adding the claim", error = ex.Message });
            }
        }

        [HttpPut("{userId}/claims/{type}")]
        public async Task<IActionResult> UpdateClaim(string userId, string type, [FromBody] ClaimDto model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest("Claim data cannot be null");
                }

                var user = await _userManager.FindByIdAsync(userId);
                if (user == null) return NotFound("User not found");
                
                var claims = await _userManager.GetClaimsAsync(user);
                var oldClaim = claims.FirstOrDefault(c => c.Type == type);
                if (oldClaim == null) return NotFound($"Claim of type '{type}' not found");
                
                var resultRemove = await _userManager.RemoveClaimAsync(user, oldClaim);
                if (!resultRemove.Succeeded)
                    return BadRequest(resultRemove.Errors);
                
                var resultAdd = await _userManager.AddClaimAsync(user, new Claim(model.Type, model.Value));
                if (!resultAdd.Succeeded)
                    return BadRequest(resultAdd.Errors);
                
                return Ok(new ClaimDto { Type = model.Type, Value = model.Value });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating claim {ClaimType} for user {UserId}", type, userId);
                return StatusCode(500, new { message = "An error occurred while updating the claim", error = ex.Message });
            }
        }

        [HttpDelete("{userId}/claims/{type}")]
        public async Task<IActionResult> DeleteClaim(string userId, string type)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user == null) return NotFound("User not found");
                
                var claims = await _userManager.GetClaimsAsync(user);
                var claim = claims.FirstOrDefault(c => c.Type == type);
                if (claim == null) return NotFound($"Claim of type '{type}' not found");
                
                var result = await _userManager.RemoveClaimAsync(user, claim);
                if (!result.Succeeded)
                    return BadRequest(result.Errors);
                
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting claim {ClaimType} for user {UserId}", type, userId);
                return StatusCode(500, new { message = "An error occurred while deleting the claim", error = ex.Message });
            }
        }
    }
}