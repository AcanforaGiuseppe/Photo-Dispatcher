namespace Photo_Dispatcher
{
    public class Email
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string AttachmentPath { get; set; }

        public Email(string to, string subject, string body, string attachmentPath)
        {
            To = to;
            Subject = subject;
            Body = body;
            AttachmentPath = attachmentPath;
        }

    }

    public class EmailSettings
    {
        public string FromName { get; set; }
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUser { get; set; }
        public string SmtpPass { get; set; }
    }
}