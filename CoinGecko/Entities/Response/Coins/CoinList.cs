using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Coins
{
    public class CoinList
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}