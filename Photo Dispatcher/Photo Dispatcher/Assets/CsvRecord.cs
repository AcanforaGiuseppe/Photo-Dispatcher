namespace Photo_Dispatcher
{
    public class CsvRecord
    {
        public string PassNumber { get; set; } // Gets or sets the pass number. This can be a single pass number or multiple pass numbers separated by a delimiter (ex., '/').
        public string Email { get; set; } // Gets or sets the email address associated with the pass number(s).
    }
}