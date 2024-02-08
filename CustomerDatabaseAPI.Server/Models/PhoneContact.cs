namespace CustomerDatabaseAPI.Server.Models
{
    public class PhoneContact
    {
        public int PhoneContactID { get; set; }

        public string DayPhoneNumber { get; set; }

        public string NightPhoneNumber { get; set; }

        public bool NightContact { get; set; }

        public int CallDetailsID { get; set; }
        
    }
}
