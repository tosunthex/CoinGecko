using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Coins
{
    public class MarketDataOhlcv
    {
        [JsonProperty("current_price")]
        public Dictionary<string,double?> CurrentPrice { get; set; }

        [JsonProperty("market_cap")]
        public Dictionary<string,double?> MarketCap { get; set; }

        [JsonProperty("market_cap_rank")]
        public long MarketCapRank { get; set; }

        [JsonProperty("total_volume")]
        public Dictionary<string,double?> TotalVolume { get; set; }

        [JsonProperty("high_24h")]
        public Dictionary<string,double?> High24H { get; set; }

        [JsonProperty("low_24h")]
        public Dictionary<string,double?> Low24H { get; set; }

        [JsonProperty("price_change_24h")]
        public double? PriceChange24H { get; set; }

        [JsonProperty("price_change_percentage_24h")]
        public double? PriceChangePercentage24H { get; set; }

        [JsonProperty("market_cap_change_24h")]
        public double? MarketCapChange24H { get; set; }

        [JsonProperty("market_cap_change_percentage_24h")]
        public double? MarketCapChangePercentage24H { get; set; }

        [JsonProperty("circulating_supply")]
        public string CirculatingSupply { get; set; }

        [JsonProperty("total_supply")]
        public long? TotalSupply { get; set; }
        
    }
}