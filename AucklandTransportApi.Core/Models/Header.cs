using Newtonsoft.Json;

namespace AucklandTransportApi.Core.Models
{
    public class Header
    {
        [JsonProperty("gtfs_realtime_version")]
        public string GtfsRealtimeVersion { get; set; }
        public int Incrementality { get; set; }
        public float Timestamp { get; set; }
    }
}
