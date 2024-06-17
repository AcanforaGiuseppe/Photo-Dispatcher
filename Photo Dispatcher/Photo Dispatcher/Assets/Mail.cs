namespace Photo_Dispatcher
{
    public class Mail
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string AttachmentPath { get; set; }

        public Mail(string to, string subject, string body, string attachmentPath)
        {
            To = to;
            Subject = subject;
            Body = body;
            AttachmentPath = attachmentPath;
        }

    }
}