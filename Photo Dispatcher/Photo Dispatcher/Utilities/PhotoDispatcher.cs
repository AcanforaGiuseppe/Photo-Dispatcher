namespace Photo_Dispatcher
{
    /// <summary>
    /// This class is responsible for dispatching photos via email. It handles loading the email mappings from a CSV file,
    /// finding the corresponding photos, and sending the emails with the photos attached.
    /// </summary>
    public class PhotoDispatch
    {
        private readonly string _photosDirectory;
        private readonly CsvLoader _csvLoader;
        private readonly EmailSender _emailSender;
        private readonly string _emailSubject;
        private readonly string _emailBody;

        public PhotoDispatch(string photosDirectory, CsvLoader csvLoader, EmailSender emailSender, string emailSubject, string emailBody)
        {
            _photosDirectory = photosDirectory;
            _csvLoader = csvLoader;
            _emailSender = emailSender;
            _emailSubject = emailSubject;
            _emailBody = emailBody;
        }

        /// <summary>
        /// Dispatches the photos by reading the CSV file, finding the corresponding photos, and sending them via email.
        /// </summary>
        /// <param name="csvFilePath">The path to the CSV file containing email mappings.</param>
        public void DispatchPhotos(string csvFilePath)
        {
            try
            {
                var passEmailMap = _csvLoader.LoadPassEmailMap(csvFilePath);

                foreach(var entry in passEmailMap)
                {
                    string passNumber = entry.Key;
                    string email = entry.Value;

                    //                                                          !!!!! TO HANDLE THE PHOTOPATH (NAMING CONVENTIONS ETC...) !!!!!

                    string photoPath = Path.Combine(_photosDirectory, $"{passNumber}.jpg");

                    //                                                          !!!!! TO HANDLE THE PHOTOPATH (NAMING CONVENTIONS ETC...) !!!!!

                    if(File.Exists(photoPath))
                    {
                        var mail = new Email(email, _emailSubject, _emailBody, photoPath);
                        _emailSender.SendEmail(mail);
                    }
                    else
                    {
                        Console.WriteLine($"Photo for pass number {passNumber} not found.");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(@$"DispatchPhotos failed - Source: {ex.Source}, Message: {ex.Message}, InnerException: {ex.InnerException}, HelpLink: {ex.HelpLink}");
            }
        }

    }
}