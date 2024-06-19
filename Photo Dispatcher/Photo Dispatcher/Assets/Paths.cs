namespace Photo_Dispatcher
{
    // Model for paths configuration section
    public class Paths
    {
        public string PhotosDirectory { get; set; } // The directory where photos are stored
        public string CsvFilePath { get; set; } // The path to the CSV file with email mappings
    }
}