using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Events
{
    public class EventCountry
    {
        [JsonProperty("data")]
        public EventCountryData[] Data { get; set; }

        [JsonProperty("count")]
        public long? Count { get; set; }
    }

    public class EventCountryData
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}