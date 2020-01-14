﻿namespace WiFiSharing.DAL.Entities
{
    using System.Collections.Generic;
    using WiFiSharing.Common.Enums;

    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PassportCode { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public List<Order> Orders { get; set; }
    }
}
