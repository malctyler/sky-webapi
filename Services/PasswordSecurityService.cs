using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Identity;
using sky_webapi.Data.Entities;

namespace sky_webapi.Services
{
    public interface IPasswordSecurityService
    {
        string HashPasswordForTransmission(string password, string email);
        bool VerifyTransmissionPassword(string password, string email, string receivedHash);
        bool ValidateNonce(string nonce, long timestamp);
        Task<bool> VerifySecurePassword(string email, string receivedHash, UserManager<ApplicationUser> userManager);
    }

    public class PasswordSecurityService : IPasswordSecurityService
    {
        private const string SALT_PREFIX = "sky_auth_2025_";
        private const int ITERATIONS = 10000;        private const int KEY_SIZE = 32; // 256 bits / 8
        private const int NONCE_VALIDITY_MINUTES = 5; // Nonce valid for 5 minutes

        public string HashPasswordForTransmission(string password, string email)
        {
            try
            {
                // Create salt based on email and static prefix (same as frontend)
                var saltString = SALT_PREFIX + email.ToLowerInvariant();
                var saltHash = SHA256.HashData(Encoding.UTF8.GetBytes(saltString));
                
                // Convert to hex string to match frontend behavior
                var saltHex = Convert.ToHexString(saltHash).ToLowerInvariant();
                var saltBytes = Encoding.UTF8.GetBytes(saltHex);

                // Use PBKDF2 to hash the password (same as frontend)
                using var pbkdf2 = new Rfc2898DeriveBytes(
                    Encoding.UTF8.GetBytes(password),
                    saltBytes,
                    ITERATIONS,
                    HashAlgorithmName.SHA256
                );

                var hash = pbkdf2.GetBytes(KEY_SIZE);
                return Convert.ToBase64String(hash);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to hash password for transmission", ex);
            }
        }

        public bool VerifyTransmissionPassword(string password, string email, string receivedHash)
        {
            try
            {
                var expectedHash = HashPasswordForTransmission(password, email);
                return string.Equals(expectedHash, receivedHash, StringComparison.Ordinal);
            }
            catch
            {
                return false;
            }
        }        public async Task<bool> VerifySecurePassword(string email, string receivedHash, UserManager<ApplicationUser> userManager)
        {
            try
            {
                Console.WriteLine($"[DEBUG] VerifySecurePassword called - Email: {email}, ReceivedHash: {receivedHash?.Substring(0, Math.Min(20, receivedHash?.Length ?? 0))}...");
                
                var user = await userManager.FindByEmailAsync(email);
                if (user == null)
                {
                    Console.WriteLine($"[DEBUG] User not found for email: {email}");
                    return false;
                }

                // The challenge: we need to verify the received hash against the user's actual password,
                // but we don't store plaintext passwords. 
                // 
                // Solution: We'll temporarily store a custom claim with the transmission hash
                // when the user sets their password, or implement a different verification approach.
                // 
                // For now, let's implement a brute-force approach for common passwords
                // and add a mechanism to store transmission hashes for new users.
                  var claims = await userManager.GetClaimsAsync(user);
                var storedTransmissionHash = claims.FirstOrDefault(c => c.Type == "TransmissionPasswordHash")?.Value;
                
                if (!string.IsNullOrEmpty(storedTransmissionHash))
                {
                    var hashMatch = string.Equals(storedTransmissionHash, receivedHash, StringComparison.Ordinal);
                    return hashMatch;
                }

                // User has no transmission hash stored - secure login not available
                return false;
            }            catch
            {
                // Log the exception in a real application
                return false;
            }
        }

        public bool ValidateNonce(string nonce, long timestamp)
        {
            try
            {
                // Check if nonce is not empty
                if (string.IsNullOrWhiteSpace(nonce))
                    return false;

                // Convert timestamp to DateTime
                var requestTime = DateTimeOffset.FromUnixTimeMilliseconds(timestamp);
                var currentTime = DateTimeOffset.UtcNow;

                // Check if request is within validity window
                var timeDifference = currentTime - requestTime;
                if (timeDifference.TotalMinutes > NONCE_VALIDITY_MINUTES)
                    return false;

                // Check if request is not from the future (allow small clock skew)
                if (timeDifference.TotalMinutes < -1)
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
