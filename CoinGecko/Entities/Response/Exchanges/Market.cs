using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Exchanges
{
    public class Market
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("has_trading_incentive")]
        public bool HasTradingIncentive { get; set; }
    }
}