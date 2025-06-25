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

        public EmailService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task SendCertificateEmailAsync(byte[] pdfBytes, string toEmail, string filename = "certificate.pdf")
        {
            var fromAddress = new MailAddress(_emailSettings.FromEmail, _emailSettings.FromName);
            var toAddress = new MailAddress("malcolm@thetylers.co.uk", "Malcolm"); // Hardcoded for development
            const string subject = "Plant Inspection Certificate";
            const string body = "Please find attached your plant inspection certificate.";

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
                Body = body
            };

            // Attach the PDF with the provided filename
            using var ms = new MemoryStream(pdfBytes);
            message.Attachments.Add(new Attachment(ms, filename, "application/pdf"));

            await smtp.SendMailAsync(message);
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
