using Newtonsoft.Json;

namespace AucklandTransportApi.Models
{
    public class Trip
    {
        [JsonProperty("trip_id")]
        public string TripId { get; set; }
        [JsonProperty("route_id")]
        public string RouteId { get; set; }
        [JsonProperty("start_time")]
        public string StartTime { get; set; }
        [JsonProperty("schedule_relationship")]
        public int ScheduleRelationship { get; set; }
    }
}
