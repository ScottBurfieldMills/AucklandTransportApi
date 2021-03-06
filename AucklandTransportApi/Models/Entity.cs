﻿using Newtonsoft.Json;

namespace AucklandTransportApi.Models
{
    public class Entity
    {
        public string Id { get; set; }
        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
