using System;
using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Exchanges
{
    public class Exchanges:ExchangesMain
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("year_established")]
        public long? YearEstablished { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }
}