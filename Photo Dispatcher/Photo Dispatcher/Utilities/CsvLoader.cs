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

            using(var reader = new StreamReader(csvFilePath))
            {
                using(var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    var records = csv.GetRecords<CsvRecord>();

                    foreach(var record in records)
                        passEmailMap[record.PassNumber] = record.Email;
                }
            }

            return passEmailMap;
        }

    }
}