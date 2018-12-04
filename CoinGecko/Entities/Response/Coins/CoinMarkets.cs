using System;
using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Coins
{
    public class CoinMarkets:MarketDataOhlcv
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("ath")]
        public double Ath { get; set; }

        [JsonProperty("ath_change_percentage")]
        public double AthChangePercentage { get; set; }

        [JsonProperty("ath_date")]
        public DateTimeOffset AthDate { get; set; }

        [JsonProperty("roi")]
        public Roi Roi { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }
        
        [JsonProperty("sparkline_in_7d")]
        public SparklineIn7D SparklineIn7D { get; set; }
    }
}