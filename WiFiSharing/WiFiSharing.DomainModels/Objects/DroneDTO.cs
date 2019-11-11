namespace WiFiSharing.DTOs.Objects
{
    using System.Collections.Generic;

    public class DroneDTO
    {
        public int Id { get; set; }
        public int CapacityInMinutes { get; set; }
        public int WiFiRangeInMeters { get; set; }
        public int DroneRangeInMeters { get; set; }
        public bool IsBusy { get; set; }
        public string WiFiPassword { get; set; }
        public List<OrderDTO> Orders { get; set; }
    }
}
