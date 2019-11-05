using System;
using WiFiSharing.Common.Enums;

namespace WiFiSharing.Common.Entities
{
    public class Order
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Drone Drone { get; set; }
        public int DroneId { get; set; }
        public DateTime Date { get; set; }
        public bool Relevance { get; set; }
        public OrderType Type { get; set; }
    }
}
