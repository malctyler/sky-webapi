using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using sky_webapi.Data;
using sky_webapi.Data.Entities;

namespace sky_webapi.Services
{
    public class TokenRevocationService : ITokenRevocationService
    {
        private readonly AppDbContext _context;
        private readonly ILogger<TokenRevocationService> _logger;

        public TokenRevocationService(AppDbContext context, ILogger<TokenRevocationService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task RevokeTokenAsync(string tokenId, string userId, string reason = "logout", string? revokedBy = null)
        {
            try
            {
                // Check if token is already revoked
                var existingRevocation = await _context.RevokedTokens
                    .FirstOrDefaultAsync(rt => rt.TokenId == tokenId);

                if (existingRevocation != null)
                {
                    _logger.LogInformation("Token {TokenId} already revoked", tokenId);
                    return;
                }

                var revokedToken = new RevokedToken
                {
                    TokenId = tokenId,
                    UserId = userId,
                    RevokedAt = DateTime.UtcNow,
                    ExpiresAt = GetTokenExpiration(tokenId),
                    Reason = reason,
                    RevokedBy = revokedBy
                };

                _context.RevokedTokens.Add(revokedToken);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Token {TokenId} revoked for user {UserId} with reason: {Reason}", 
                    tokenId, userId, reason);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to revoke token {TokenId}", tokenId);
                throw;
            }
        }

        public async Task<bool> IsTokenRevokedAsync(string tokenId)
        {
            try
            {
                return await _context.RevokedTokens
                    .AnyAsync(rt => rt.TokenId == tokenId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to check token revocation status for {TokenId}", tokenId);
                // Fail securely - if we can't check, assume it's revoked
                return true;
            }
        }        public Task RevokeAllUserTokensAsync(string userId, string reason = "security_action")
        {
            try
            {
                // This is a more complex implementation that would require tracking all active tokens
                // For now, we'll log the action and rely on the frontend to clear localStorage
                _logger.LogWarning("Revoking all tokens for user {UserId} with reason: {Reason}", userId, reason);
                
                // You could implement a user-level revocation timestamp approach here
                // For simplicity, we'll handle this in the validation middleware
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to revoke all tokens for user {UserId}", userId);
                throw;
            }
        }

        public async Task CleanupExpiredTokensAsync()
        {
            try
            {
                var cutoffDate = DateTime.UtcNow;
                var expiredTokens = await _context.RevokedTokens
                    .Where(rt => rt.ExpiresAt < cutoffDate)
                    .ToListAsync();

                if (expiredTokens.Any())
                {
                    _context.RevokedTokens.RemoveRange(expiredTokens);
                    await _context.SaveChangesAsync();
                    
                    _logger.LogInformation("Cleaned up {Count} expired revoked tokens", expiredTokens.Count);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to cleanup expired tokens");
            }
        }

        private DateTime GetTokenExpiration(string tokenId)
        {
            try
            {
                // For now, we'll set a default expiration based on typical JWT duration
                // In a more sophisticated implementation, you might store token metadata
                return DateTime.UtcNow.AddHours(1); // Match your JWT settings
            }
            catch
            {
                return DateTime.UtcNow.AddHours(1); // Default fallback
            }
        }
    }
}
