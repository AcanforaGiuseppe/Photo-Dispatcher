using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.Extensions.Logging;
using System.Globalization;

namespace Photo_Dispatcher
{
    /// <summary>
    /// This class is responsible for loading and parsing a CSV file that maps pass numbers to email addresses.
    /// It reads the CSV file and returns a dictionary with the pass numbers as keys and the email addresses as values.
    /// </summary>
    public class CsvLoader
    {
        private readonly ILogger<CsvLoader> _logger;

        public CsvLoader(ILogger<CsvLoader> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Loads the pass number to email address mapping from a specified CSV file.
        /// </summary>
        /// <param name="csvFilePath">The path to the CSV file.</param>
        /// <returns>A dictionary where the keys are pass numbers and the values are email addresses.</returns>
        public Dictionary<string, string> LoadPassEmailMap(string csvFilePath)
        {
            var passEmailMap = new Dictionary<string, string>();

            try
            {
                _logger.LogInformation($"Attempting to load CSV file from path: {csvFilePath}");

                using(var reader = new StreamReader(csvFilePath))
                {
                    using(var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                        var records = csv.GetRecords<CsvRecord>();

                        foreach(var record in records)
                        {
                            passEmailMap[record.PassNumber] = record.Email;
                        }
                    }
                }

                _logger.LogInformation("CSV file loaded successfully.");
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, @$"CSV load action failed - Source: {ex.Source}, Message: {ex.Message}, InnerException: {ex.InnerException}, HelpLink: {ex.HelpLink}");
            }

            return passEmailMap;
        }

    }
}