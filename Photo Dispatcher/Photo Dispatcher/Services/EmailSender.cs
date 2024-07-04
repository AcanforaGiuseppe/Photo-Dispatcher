using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

namespace Photo_Dispatcher
{
    /// <summary>
    /// This class is responsible for sending emails using the provided SMTP server settings.
    /// It handles the creation and dispatching of email messages, including attachments.
    /// </summary>
    public class EmailSender
    {
        private readonly string _smtpServer;
        private readonly int _smtpPort;
        private readonly string _smtpUser;
        private readonly string _smtpPass;
        private readonly string _fromName;
        private readonly ILogger<EmailSender> _logger;

        public EmailSender(IOptions<EmailSettings> emailSettings, ILogger<EmailSender> logger)
        {
            var settings = emailSettings.Value;
            _smtpServer = settings.SmtpServer;
            _smtpPort = settings.SmtpPort;
            _smtpUser = settings.SmtpUser;
            _smtpPass = settings.SmtpPass;
            _fromName = settings.FromName;
            _logger = logger;
        }

        /// <summary>
        /// Sends an email using the specified email details.
        /// </summary>
        /// <param name="mail">The email details including recipient, subject, body, and optional attachment.</param>
        public void SendEmail(Email mail)
        {
            try
            {
                var fromAddress = new MailAddress(_smtpUser, _fromName);
                var toAddress = new MailAddress(mail.To);
                var smtp = new SmtpClient
                {
                    Host = _smtpServer,
                    Port = _smtpPort,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, _smtpPass)
                };

                using(var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = mail.Subject,
                    Body = mail.Body
                })
                {
                    foreach(var attachmentPath in mail.AttachmentPaths)
                        message.Attachments.Add(new Attachment(attachmentPath));

                    try
                    {
                        smtp.Send(message);
                        _logger.LogInformation($"Email successfully sent to {mail.To} with photos: {string.Join(", ", mail.AttachmentPaths)}");
                    }
                    catch(SmtpException smtpEx)
                    {
                        _logger.LogError(smtpEx, $"SMTP error occurred while sending email to {mail.To} - Source: {smtpEx.Source}, Message: {smtpEx.Message}, InnerException: {smtpEx.InnerException}, HelpLink: {smtpEx.HelpLink}");
                    }
                    catch(Exception ex)
                    {
                        _logger.LogError(ex, $"An error occurred while sending email to {mail.To} - Source: {ex.Source}, Message: {ex.Message}, InnerException: {ex.InnerException}, HelpLink: {ex.HelpLink}");
                    }
                }
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, $"Failed to prepare email for {mail.To} - Source: {ex.Source}, Message: {ex.Message}, InnerException: {ex.InnerException}, HelpLink: {ex.HelpLink}");
            }
        }

    }
}