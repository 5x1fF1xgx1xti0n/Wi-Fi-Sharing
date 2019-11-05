namespace WiFiSharing.Common.Entities
{
    using System.Collections.Generic;

    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PassportCode { get; set; }
        public string Phone { get; set; }
        public List<Order> Orders { get; set; }
    }
}
