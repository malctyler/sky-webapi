using System.IdentityModel.Tokens.Jwt;

namespace sky_webapi.Services
{
    public class TokenRevocationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<TokenRevocationMiddleware> _logger;

        public TokenRevocationMiddleware(RequestDelegate next, ILogger<TokenRevocationMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, ITokenRevocationService tokenRevocationService)
        {
            // Skip for non-authenticated endpoints
            if (!context.Request.Path.StartsWithSegments("/api") || 
                context.Request.Path.StartsWithSegments("/api/auth/login") ||
                context.Request.Path.StartsWithSegments("/api/auth/register") ||
                context.Request.Path.StartsWithSegments("/api/auth/secure-login"))
            {
                await _next(context);
                return;
            }

            // Extract JWT token from Authorization header or cookies
            string? token = null;
            
            // Try Authorization header first
            var authHeader = context.Request.Headers["Authorization"].FirstOrDefault();
            if (authHeader?.StartsWith("Bearer ") == true)
            {
                token = authHeader.Substring("Bearer ".Length).Trim();
            }
            else
            {
                // Fallback to cookie
                token = context.Request.Cookies["auth_token"];
            }

            if (!string.IsNullOrEmpty(token))
            {
                try
                {
                    // Parse JWT to get jti claim (token ID)
                    var handler = new JwtSecurityTokenHandler();
                    var jwtToken = handler.ReadJwtToken(token);
                    
                    var tokenId = jwtToken.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti)?.Value;
                    
                    if (!string.IsNullOrEmpty(tokenId))
                    {
                        // Check if token is revoked
                        var isRevoked = await tokenRevocationService.IsTokenRevokedAsync(tokenId);
                        
                        if (isRevoked)
                        {
                            _logger.LogWarning("Revoked token attempted access: {TokenId}", tokenId);
                            context.Response.StatusCode = 401;
                            context.Response.ContentType = "application/json";
                            await context.Response.WriteAsJsonAsync(new { Message = "Token has been revoked" });
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error validating token revocation status");
                    // Continue processing - let normal JWT validation handle invalid tokens
                }
            }

            await _next(context);
        }
    }
}
