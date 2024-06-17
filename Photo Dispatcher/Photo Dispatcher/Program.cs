using Photo_Dispatcher;

namespace PhotoDispatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string photosDirectory = @"C:\Users\acanf\Desktop\Photos";
            string csvFilePath = @"C:\Users\acanf\Desktop\emails.csv";

            var csvLoader = new CsvLoader();
            var emailSender = new EmailSender("smtp.example.com", 587, "your-email@example.com", "your-email-password");
            var photoDispatcher = new PhotoDispatch(photosDirectory, csvLoader, emailSender);

            photoDispatcher.DispatchPhotos(csvFilePath);

            Console.WriteLine("Process completed. Press any key to exit.");
            Console.ReadKey();
        }

    }
}