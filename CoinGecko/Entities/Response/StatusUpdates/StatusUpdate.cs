using System;
using CoinGecko.Entities.Response.Shared;
using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.StatusUpdates
{
    public partial class StatusUpdate
    {
        [JsonProperty("status_updates")]
        public StatusUpdateElement[] StatusUpdates { get; set; }
    }

    public partial class StatusUpdateElement
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("user_title")]
        public string UserTitle { get; set; }

        [JsonProperty("pin")]
        public bool Pin { get; set; }

        [JsonProperty("project")]
        public Project Project { get; set; }
    }

    public partial class Project
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string Symbol { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }
    }
}