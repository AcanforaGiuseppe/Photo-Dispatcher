using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace Photo_Dispatcher
{
    public class CsvLoader
    {
        public Dictionary<string, string> LoadPassEmailMap(string csvFilePath)
        {
            var passEmailMap = new Dictionary<string, string>();

            try
            {
                using(var reader = new StreamReader(csvFilePath))
                {
                    using(var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                        var records = csv.GetRecords<CsvRecord>();

                        foreach(var record in records)
                            passEmailMap[record.PassNumber] = record.Email;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(@$"CSV read action failed - Source: {ex.Source}, Message: {ex.Message}, InnerException: {ex.InnerException}, HelpLink: {ex.HelpLink}");
            }

            return passEmailMap;
        }

    }
}