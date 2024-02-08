namespace CustomerDatabaseAPI.Server.Models
{
    public class Customer
    {

        public int CustomerInfoId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PrimaryEmail { get; set; }

        public string SecondaryEmail { get; set; }

        public int CustomerPhoneID { get; set; }

        public int CustomerAddressID { get; set; }


    }
}
