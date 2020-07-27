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

        [JsonProperty("current_price")]
        public double? CurrentPrice { get; set; }

        [JsonProperty("market_cap")]
        public double? MarketCap { get; set; }

        [JsonProperty("total_volume")]
        public double? TotalVolume { get; set; }

        [JsonProperty("high_24h")]
        public double? High24H { get; set; }

        [JsonProperty("low_24h")]
        public double? Low24H { get; set; }

        [JsonProperty("ath")]
        public double? Ath { get; set; }

        [JsonProperty("ath_change_percentage")]
        public double? AthChangePercentage { get; set; }

        [JsonProperty("ath_date")]
        public DateTimeOffset AthDate { get; set; }

        [JsonProperty("roi")]
        public Roi Roi { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }
        
        [JsonProperty("sparkline_in_7d",NullValueHandling = NullValueHandling.Ignore)]
        public SparklineIn7D SparklineIn7D { get; set; }
        
        [JsonProperty("price_change_percentage_14d_in_currency",NullValueHandling = NullValueHandling.Ignore)]
        public double? PriceChangePercentage14DInCurrency { get; set; }

        [JsonProperty("price_change_percentage_1h_in_currency",NullValueHandling = NullValueHandling.Ignore)]
        public double? PriceChangePercentage1HInCurrency { get; set; }

        [JsonProperty("price_change_percentage_1y_in_currency",NullValueHandling = NullValueHandling.Ignore)]
        public double? PriceChangePercentage1YInCurrency { get; set; }

        [JsonProperty("price_change_percentage_200d_in_currency",NullValueHandling = NullValueHandling.Ignore)]
        public double? PriceChangePercentage200DInCurrency { get; set; }

        [JsonProperty("price_change_percentage_24h_in_currency",NullValueHandling = NullValueHandling.Ignore)]
        public double? PriceChangePercentage24HInCurrency { get; set; }

        [JsonProperty("price_change_percentage_30d_in_currency",NullValueHandling = NullValueHandling.Ignore)]
        public double? PriceChangePercentage30DInCurrency { get; set; }

        [JsonProperty("price_change_percentage_7d_in_currency",NullValueHandling = NullValueHandling.Ignore)]
        public double? PriceChangePercentage7DInCurrency { get; set; }
    }
}