using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Coins
{
    public class MarketDataOhlcv
    {
        [JsonProperty("current_price")]
        public double CurrentPrice { get; set; }

        [JsonProperty("market_cap")]
        public double MarketCap { get; set; }

        [JsonProperty("market_cap_rank")]
        public long MarketCapRank { get; set; }

        [JsonProperty("total_volume")]
        public double TotalVolume { get; set; }

        [JsonProperty("high_24h")]
        public double High24H { get; set; }

        [JsonProperty("low_24h")]
        public double Low24H { get; set; }

        [JsonProperty("price_change_24h")]
        public double PriceChange24H { get; set; }

        [JsonProperty("price_change_percentage_24h")]
        public double PriceChangePercentage24H { get; set; }

        [JsonProperty("market_cap_change_24h")]
        public double MarketCapChange24H { get; set; }

        [JsonProperty("market_cap_change_percentage_24h")]
        public double MarketCapChangePercentage24H { get; set; }

        [JsonProperty("circulating_supply")]
        public string CirculatingSupply { get; set; }

        [JsonProperty("total_supply")]
        public long? TotalSupply { get; set; }
        
    }
}