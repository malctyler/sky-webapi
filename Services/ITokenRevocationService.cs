using sky_webapi.Data.Entities;

namespace sky_webapi.Services
{
    public interface ITokenRevocationService
    {
        Task RevokeTokenAsync(string tokenId, string userId, string reason = "logout", string? revokedBy = null);
        Task<bool> IsTokenRevokedAsync(string tokenId);
        Task RevokeAllUserTokensAsync(string userId, string reason = "security_action");
        Task CleanupExpiredTokensAsync();
    }
}
