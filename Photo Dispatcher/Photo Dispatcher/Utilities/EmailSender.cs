using System.Net;
using System.Net.Mail;

namespace Photo_Dispatcher
{
    public class EmailSender
    {
        private readonly string _smtpServer;
        private readonly int _smtpPort;
        private readonly string _smtpUser;
        private readonly string _smtpPass;

        public EmailSender(string smtpServer, int smtpPort, string smtpUser, string smtpPass)
        {
            _smtpServer = smtpServer;
            _smtpPort = smtpPort;
            _smtpUser = smtpUser;
            _smtpPass = smtpPass;
        }

        public void SendEmail(Mail mail)
        {
            try
            {
                var fromAddress = new MailAddress(_smtpUser, "Your Name");
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
                Console.WriteLine($"Failed to send email to {mail.To}. Error: {ex.Message}");
            }
        }

    }
}