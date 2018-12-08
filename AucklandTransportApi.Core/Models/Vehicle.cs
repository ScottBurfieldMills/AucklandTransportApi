using Newtonsoft.Json;

namespace AucklandTransportApi.Core.Models
{
    public class Vehicle
    {
        public Trip Trip { get; set; }
        [JsonProperty("vehicle")]
        public VehicleId VehicleId { get; set; }
        public Position Position { get; set; }
        public float Timestamp { get; set; }
        [JsonProperty("occupancy_status")]
        public int OccupancyStatus { get; set; }
    }
}
