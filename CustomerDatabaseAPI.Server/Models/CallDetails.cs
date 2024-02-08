namespace CustomerDatabaseAPI.Server.Models
{
    public class CallDetails
    {
        public int CallDetailsID { get; set; }

        public int ContactAttepts { get; set; }

        public DateTime LastCallDate { get; set; }

        public string CallNotes { get; set; }
    }
}
