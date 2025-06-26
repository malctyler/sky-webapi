using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Options;

namespace sky_webapi.Services
{
    public interface IEmailService
    {
        Task SendCertificateEmailAsync(byte[] pdfBytes, string toEmail, string filename = "certificate.pdf");
        Task SendPasswordResetEmailAsync(string toEmail, string resetToken, string resetUrl);
    }

    public class EmailService : IEmailService
    {
        private readonly EmailSettings _emailSettings;
        private readonly ILogger<EmailService> _logger;

        public EmailService(IOptions<EmailSettings> emailSettings, ILogger<EmailService> logger)
        {
            _emailSettings = emailSettings.Value;
            _logger = logger;
        }

        public async Task SendCertificateEmailAsync(byte[] pdfBytes, string toEmail, string filename = "certificate.pdf")
        {
            try
            {
                _logger.LogInformation("Starting certificate email send to {ToEmail}, filename: {Filename}, size: {Size} bytes", 
                    toEmail, filename, pdfBytes.Length);

                // Validate email settings
                ValidateEmailSettings();

                var fromAddress = new MailAddress(_emailSettings.FromEmail, _emailSettings.FromName);
                var toAddress = new MailAddress("malcolm@thetylers.co.uk", "Malcolm"); // Hardcoded for development
                const string subject = "Plant Inspection Certificate";
                const string body = "Please find attached your plant inspection certificate.";

                _logger.LogInformation("Creating SMTP client for server {SmtpServer}:{SmtpPort}, SSL: {EnableSsl}", 
                    _emailSettings.SmtpServer, _emailSettings.SmtpPort, _emailSettings.EnableSsl);

                using var smtp = new SmtpClient
                {
                    Host = _emailSettings.SmtpServer,
                    Port = _emailSettings.SmtpPort,
                    EnableSsl = _emailSettings.EnableSsl,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(_emailSettings.SmtpUsername, _emailSettings.SmtpPassword),
                    Timeout = 30000 // 30 second timeout
                };

                using var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                };

                // Attach the PDF with the provided filename
                using var ms = new MemoryStream(pdfBytes);
                var attachment = new Attachment(ms, filename, "application/pdf");
                message.Attachments.Add(attachment);

                _logger.LogInformation("Sending email via SMTP...");
                await smtp.SendMailAsync(message);
                _logger.LogInformation("Certificate email sent successfully to {ToEmail}", toEmail);
            }
            catch (SmtpException ex)
            {
                _logger.LogError(ex, "SMTP error sending certificate email to {ToEmail}: {Message}", toEmail, ex.Message);
                throw new InvalidOperationException($"SMTP error: {ex.Message}", ex);
            }
            catch (ArgumentException ex)
            {
                _logger.LogError(ex, "Argument error sending certificate email to {ToEmail}: {Message}", toEmail, ex.Message);
                throw new InvalidOperationException($"Email configuration error: {ex.Message}", ex);
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogError(ex, "Configuration error sending certificate email to {ToEmail}: {Message}", toEmail, ex.Message);
                throw; // Re-throw as is
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "General error sending certificate email to {ToEmail}: {Message}", toEmail, ex.Message);
                throw new InvalidOperationException($"Email sending failed: {ex.Message}", ex);
            }
        }

        private void ValidateEmailSettings()
        {
            var errors = new List<string>();

            if (string.IsNullOrEmpty(_emailSettings.SmtpServer))
                errors.Add("SMTP server not configured");
            
            if (string.IsNullOrEmpty(_emailSettings.FromEmail))
                errors.Add("From email not configured");

            if (string.IsNullOrEmpty(_emailSettings.SmtpUsername))
                errors.Add("SMTP username not configured");

            if (string.IsNullOrEmpty(_emailSettings.SmtpPassword))
                errors.Add("SMTP password not configured");

            if (_emailSettings.SmtpPort <= 0 || _emailSettings.SmtpPort > 65535)
                errors.Add($"Invalid SMTP port: {_emailSettings.SmtpPort}");

            if (errors.Any())
            {
                var errorMessage = string.Join(", ", errors);
                _logger.LogError("Email settings validation failed: {Errors}", errorMessage);
                throw new InvalidOperationException($"Email settings validation failed: {errorMessage}");
            }

            _logger.LogInformation("Email settings validation passed");
        }

        public async Task SendPasswordResetEmailAsync(string toEmail, string resetToken, string resetUrl)
        {
            var fromAddress = new MailAddress(_emailSettings.FromEmail, _emailSettings.FromName);
            var toAddress = new MailAddress(toEmail);
            const string subject = "Password Reset Request - SKY Technical Services";
            
            var body = $@"
<html>
<body>
    <h2>Password Reset Request</h2>
    <p>Hello,</p>
    <p>You have requested to reset your password for your SKY Technical Services account.</p>
    <p>Please click the link below to reset your password. This link will expire in 24 hours:</p>
    <p><a href=""{resetUrl}"" style=""background-color: #007bff; color: white; padding: 10px 20px; text-decoration: none; border-radius: 5px;"">Reset Password</a></p>
    <p>If the button doesn't work, you can copy and paste this link into your browser:</p>
    <p>{resetUrl}</p>
    <p>If you did not request this password reset, please ignore this email and your password will remain unchanged.</p>
    <br>
    <p>Best regards,<br>SKY Technical Services Team</p>
</body>
</html>";

            using var smtp = new SmtpClient
            {
                Host = _emailSettings.SmtpServer,
                Port = _emailSettings.SmtpPort,
                EnableSsl = _emailSettings.EnableSsl,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_emailSettings.SmtpUsername, _emailSettings.SmtpPassword)
            };

            using var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            await smtp.SendMailAsync(message);
        }
    }
}
