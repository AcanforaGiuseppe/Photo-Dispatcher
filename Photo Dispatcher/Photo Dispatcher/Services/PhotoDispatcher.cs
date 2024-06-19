using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.RegularExpressions;

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
        private readonly ILogger<PhotoDispatch> _logger;

        public PhotoDispatch(IOptions<Paths> paths, IOptions<EmailSettings> emailSettings, CsvLoader csvLoader, EmailSender emailSender, ILogger<PhotoDispatch> logger)
        {
            _photosDirectory = paths.Value.PhotosDirectory;
            _csvLoader = csvLoader;
            _emailSender = emailSender;
            _emailSubject = emailSettings.Value.EmailSubject;
            _emailBody = emailSettings.Value.EmailBody;
            _logger = logger;
        }

        /// <summary>
        /// Dispatches the photos by reading the CSV file, finding the corresponding photos, and sending them via email.
        /// </summary>
        /// <param name="csvFilePath">The path to the CSV file containing email mappings.</param>
        public void DispatchPhotos(string csvFilePath)
        {
            try
            {
                _logger.LogInformation("Dispatching photos...");

                var passEmailMap = _csvLoader.LoadPassEmailMap(csvFilePath);
                var allFiles = Directory.GetFiles(_photosDirectory);

                _logger.LogInformation($"Found {allFiles.Length} files in the directory.");

                foreach(var entry in passEmailMap)
                {
                    string[] passNumbers = entry.Key.Split('/');
                    string email = entry.Value;

                    List<string> photoPaths = new List<string>();

                    foreach(var passNumber in passNumbers)
                    {
                        var regex = new Regex($@"(?<!\d){Regex.Escape(passNumber)}(?!\d)", RegexOptions.IgnoreCase);

                        var matchedFiles = allFiles
                                        .Where(file => regex.IsMatch(Path.GetFileNameWithoutExtension(file)))
                                        .ToArray();

                        if(matchedFiles.Length > 0)
                            photoPaths.AddRange(matchedFiles);
                        else
                            _logger.LogWarning($"Photo for pass number {passNumber} not found.");
                    }

                    if(photoPaths.Count > 0)
                    {
                        var mail = new Email(email, _emailSubject, _emailBody, photoPaths);
                        _emailSender.SendEmail(mail);
                        _logger.LogInformation($"Email sent to {email} with photos {string.Join(", ", photoPaths)}.");
                    }
                }

                _logger.LogInformation("Photo dispatch process completed.");
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, $"DispatchPhotos failed - Source: {ex.Source}, Message: {ex.Message}, InnerException: {ex.InnerException}, HelpLink: {ex.HelpLink}");
            }
        }

    }
}