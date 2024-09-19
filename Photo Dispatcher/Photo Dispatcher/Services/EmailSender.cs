/*
© Giuseppe Acanfora - PHOTODISPATCHER 2024. Tutti i diritti riservati.
*/
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;
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
        private readonly string _htmlTemplatePath;
        private readonly int _sendDelaySeconds;
        private readonly int _maxRetryAttempts;
        private readonly ILogger<EmailSender> _logger;

        public EmailSender(IOptions<EmailSettings> emailSettings, ILogger<EmailSender> logger)
        {
            var settings = emailSettings.Value;
            _smtpServer = settings.SmtpServer;
            _smtpPort = settings.SmtpPort;
            _smtpUser = settings.SmtpUser;
            _smtpPass = settings.SmtpPass;
            _fromName = settings.FromName;
            _htmlTemplatePath = settings.HtmlTemplatePath;
            _sendDelaySeconds = settings.SendDelaySeconds;
            _maxRetryAttempts = settings.MaxRetryAttempts;
            _logger = logger;
        }

        /// <summary>
        /// Sends an email using the specified email details, with retries and delays between attempts.
        /// </summary>
        /// <param name="mail">The email details including recipient, subject, body, and optional attachments.</param>
        public void SendEmail(Email mail)
        {
            var stopwatch = Stopwatch.StartNew(); // Start the timer for sending email
            int retryAttempts = 0;
            bool emailSent = false;

            while(retryAttempts < _maxRetryAttempts && !emailSent)
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
                        Body = GenerateEmailBody(mail.Body),  // Using the HTML template to generate the body
                        IsBodyHtml = true  // Ensuring the email body is treated as HTML
                    })
                    {
                        foreach(var attachmentPath in mail.AttachmentPaths)
                            message.Attachments.Add(new Attachment(attachmentPath));

                        try
                        {
                            smtp.Send(message);
                            stopwatch.Stop(); // Stop the timer
                            Program.IncrementEmailSentCount(stopwatch.Elapsed.TotalMilliseconds); // Log the email send time
                            _logger.LogInformation($"Email successfully sent to {mail.To} with photos: {string.Join("\n", mail.AttachmentPaths)}");
                            emailSent = true; // Email was successfully sent
                        }
                        catch(SmtpException smtpEx)
                        {
                            stopwatch.Stop(); // Stop the timer in case of an error
                            _logger.LogError(smtpEx, $"SMTP error occurred while sending email to {mail.To} - Source: {smtpEx.Source}, Message: {smtpEx.Message}, InnerException: {smtpEx.InnerException}, HelpLink: {smtpEx.HelpLink}");
                            Program.IncrementEmailNotSent();
                        }
                        catch(Exception ex)
                        {
                            stopwatch.Stop(); // Stop the timer in case of an error
                            _logger.LogError(ex, $"An error occurred while sending email to {mail.To} - Source: {ex.Source}, Message: {ex.Message}, InnerException: {ex.InnerException}, HelpLink: {ex.HelpLink}");
                            Program.IncrementEmailNotSent();
                        }
                    }
                }
                catch(Exception ex)
                {
                    _logger.LogError(ex, $"Failed to prepare email for {mail.To} - Source: {ex.Source}, Message: {ex.Message}, InnerException: {ex.InnerException}, HelpLink: {ex.HelpLink}");
                }

                if(!emailSent)
                {
                    retryAttempts++;
                    if(retryAttempts < _maxRetryAttempts)
                    {
                        _logger.LogInformation($"Retrying to send email to {mail.To}... Attempt {retryAttempts + 1} of {_maxRetryAttempts}");
                        Thread.Sleep(_sendDelaySeconds * 1000); // Wait before the next retry
                    }
                }
            }

            if(!emailSent)
            {
                _logger.LogError($"Failed to send email to {mail.To} after {retryAttempts} attempts");
                Program.IncrementEmailNotSent();
            }
        }

        /// <summary>
        /// Generates the email body by inserting the email text into the HTML template.
        /// </summary>
        /// <param name="emailBody">The plain text email body to insert into the template.</param>
        /// <returns>The final email body with the HTML template applied.</returns>
        private string GenerateEmailBody(string emailBody)
        {
            if(!File.Exists(_htmlTemplatePath))
            {
                _logger.LogWarning($"HTML template not found at {_htmlTemplatePath}. Using plain email body.");
                return emailBody;  // If the template isn't found, use the plain email body
            }

            string templateContent = File.ReadAllText(_htmlTemplatePath);
            return templateContent.Replace("{{EmailBody}}", emailBody);  // Insert the email body into the HTML template
        }

    }
}