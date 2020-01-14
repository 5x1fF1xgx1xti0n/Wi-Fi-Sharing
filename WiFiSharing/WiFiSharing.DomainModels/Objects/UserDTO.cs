namespace WiFiSharing.DTOs.Objects
{
    using System.Collections.Generic;

    public class UserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PassportCode { get; set; }
        public string Phone { get; set; }
        public List<OrderDTO> Orders { get; set; }
    }
}
