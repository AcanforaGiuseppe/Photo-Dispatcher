/*
© Giuseppe Acanfora - PHOTODISPATCHER 2024. Tutti i diritti riservati.
*/
namespace Photo_Dispatcher
{
    // Model for email details
    public class Email
    {
        public string To { get; set; } // The recipient's email address
        public string Subject { get; set; } // The subject of the email
        public string Body { get; set; } // The body of the email
        public List<string> AttachmentPaths { get; set; } // The paths to the attachments
        public string HtmlTemplate { get; set; } // The path to the HTML template

        public Email(string to, string subject, string body, List<string> attachmentPaths, string htmlTemplate)
        {
            To = to;
            Subject = subject;
            Body = body;
            AttachmentPaths = attachmentPaths;
            HtmlTemplate = htmlTemplate;
        }
    }

    // Model for email settings configuration section
    public class EmailSettings
    {
        public string FromName { get; set; } // The display name for the sender
        public string SmtpServer { get; set; } // The SMTP server address
        public int SmtpPort { get; set; } // The SMTP server port
        public string SmtpUser { get; set; } // The SMTP user name
        public string SmtpPass { get; set; } // The SMTP password
        public string EmailSubject { get; set; } // The default email subject
        public string EmailBody { get; set; } // The default email body
        public int SendDelaySeconds { get; set; } // The delay seconds between each email sent
        public int MaxRetryAttempts { get; set; } // The maximum number of retry attempts
    }
}