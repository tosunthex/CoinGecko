using Newtonsoft.Json;

namespace CoinGecko.Entities.Response
{
    public class Ping
    {
        [JsonProperty("gecko_says")]
        public string GeckoSays { get; set; }
    }
}