namespace Photo_Dispatcher
{
    public class PhotoDispatch
    {
        private readonly string _photosDirectory;
        private readonly CsvLoader _csvLoader;
        private readonly EmailSender _emailSender;

        public PhotoDispatch(string photosDirectory, CsvLoader csvLoader, EmailSender emailSender)
        {
            _photosDirectory = photosDirectory;
            _csvLoader = csvLoader;
            _emailSender = emailSender;
        }

        public void DispatchPhotos(string csvFilePath)
        {
            var passEmailMap = _csvLoader.LoadPassEmailMap(csvFilePath);

            foreach(var entry in passEmailMap)
            {
                string passNumber = entry.Key;
                string email = entry.Value;
                string photoPath = Path.Combine(_photosDirectory, passNumber);

                if(File.Exists(photoPath))
                {
                    var mail = new Mail(email, "Your Photo from the Event", "Dear attendee, please find attached your photo from the event.", photoPath);
                    _emailSender.SendEmail(mail);
                }
                else
                {
                    Console.WriteLine($"Photo for pass number {passNumber} not found.");
                }
            }
        }

    }
}