namespace Photo_Dispatcher
{
    public class Photo
    {
        public string PassNumber { get; set; }
        public string FilePath { get; set; }

        public Photo(string passNumber, string filePath)
        {
            PassNumber = passNumber;
            FilePath = filePath;
        }

    }
}