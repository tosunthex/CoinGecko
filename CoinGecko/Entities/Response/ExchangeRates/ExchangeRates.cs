using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.ExchangeRates
{
    public class ExchangeRates
    {
        [JsonProperty("rates")]
        public Dictionary<string, Rate> Rates { get; set; }
    }

    public class Rate
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public decimal? Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}