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

        public EmailSender(string smtpServer, int smtpPort, string smtpUser, string smtpPass, string fromName)
        {
            _smtpServer = smtpServer;
            _smtpPort = smtpPort;
            _smtpUser = smtpUser;
            _smtpPass = smtpPass;
            _fromName = fromName;
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
                    if(!string.IsNullOrEmpty(mail.AttachmentPath))
                        message.Attachments.Add(new Attachment(mail.AttachmentPath));

                    smtp.Send(message);
                }

                Console.WriteLine($"Email sent to {mail.To} with photo {mail.AttachmentPath}.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(@$"Failed to send email to {mail.To}. - Source: {ex.Source}, Message: {ex.Message}, InnerException: {ex.InnerException}, HelpLink: {ex.HelpLink}");
            }
        }

    }
}