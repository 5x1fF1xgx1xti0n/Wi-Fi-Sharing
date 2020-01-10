using System;

namespace WiFiSharing.DTOs.Objects
{
    public class Token
    {
        public string Value { get; set; }
        public string UserEmail { get; set; }
        public DateTime Expires { get; set; }
    }
}
