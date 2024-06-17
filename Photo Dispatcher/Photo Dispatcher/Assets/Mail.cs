namespace Photo_Dispatcher
{
    public class Mail
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string PhotoPath { get; set; }

        public Mail(string to, string subject, string body, string photoPath)
        {
            To = to;
            Subject = subject;
            Body = body;
            PhotoPath = photoPath;
        }

    }
}