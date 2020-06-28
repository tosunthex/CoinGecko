using System;
using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Finance
{
    public class FinancePlatforms
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("facts")]
        public string Facts { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("centralized")]
        public bool Centralized { get; set; }

        [JsonProperty("website_url")]
        public Uri WebsiteUrl { get; set; }
    }
}