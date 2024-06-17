using Microsoft.Extensions.Configuration;
using Photo_Dispatcher;

namespace PhotoDispatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                             .SetBasePath(Directory.GetCurrentDirectory())
                             .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                             .Build();

            var emailSettings = configuration.GetSection("EmailSettings").Get<EmailSettings>();
            var paths = configuration.GetSection("Paths").Get<Paths>();

            var emailSender = new EmailSender(emailSettings.SmtpServer, emailSettings.SmtpPort, emailSettings.SmtpUser, emailSettings.SmtpPass, emailSettings.FromName);
            var csvLoader = new CsvLoader();
            var photoDispatcher = new PhotoDispatch(paths.PhotosDirectory, csvLoader, emailSender);

            try
            {
                photoDispatcher.DispatchPhotos(paths.CsvFilePath);
            }
            catch(Exception ex)
            {
                Console.WriteLine(@$"DispatchPhotos failed - Source: {ex.Source}, Message: {ex.Message}, InnerException: {ex.InnerException}, HelpLink: {ex.HelpLink}");
            }

            Console.WriteLine("Process completed. Press any key to exit.");
            Console.ReadKey();
        }

    }
}