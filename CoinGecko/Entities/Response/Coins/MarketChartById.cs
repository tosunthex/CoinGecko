using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Coins
{
    public class MarketChartById
    {
        [JsonProperty("prices")]
        public decimal?[][] Prices { get; set; }

        [JsonProperty("market_caps")]
        public decimal?[][] MarketCaps { get; set; }

        [JsonProperty("total_volumes")]
        public decimal?[][] TotalVolumes { get; set; }
    }
}