using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Exchanges
{
    public class ExchangesList
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}