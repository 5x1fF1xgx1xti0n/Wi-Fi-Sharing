namespace WiFiSharing.DTOs.Objects
{
    using System;
    using WiFiSharing.Common.Enums;

    public class OrderDTO
    {
        public UserDTO User { get; set; }
        public int UserId { get; set; }
        public DroneDTO Drone { get; set; }
        public int DroneId { get; set; }
        public DateTime Date { get; set; }
        public bool Relevance { get; set; }
        public OrderType Type { get; set; }
    }
}
