using Newtonsoft.Json;
using System.Collections.Generic;

namespace AucklandTransportApi.Core.Models
{
    public class Response
    {
        public Header Header { get; set; }
        [JsonProperty("entity")]
        public List<Entity> Entities { get; set; }
    }
}
