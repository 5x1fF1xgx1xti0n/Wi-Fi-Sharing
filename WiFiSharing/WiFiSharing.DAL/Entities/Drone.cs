namespace WiFiSharing.DAL.Entities
{
    using System.Collections.Generic;

    public class Drone
    {
        public int Id { get; set; }
        public int CapacityInMinutes { get; set; }
        public int WiFiRangeInMeters { get; set; }
        public int DroneRangeInMeters { get; set; }
        public bool IsBusy { get; set; }
        public string WiFiPassword { get; set; }
        public List<Order> Orders { get; set; }
    }
}
