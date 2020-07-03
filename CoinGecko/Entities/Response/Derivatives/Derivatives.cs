using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Derivatives
{
    public class Derivatives
    {
        [JsonProperty("market")]
        public string Market { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("coin_id")]
        public string CoinId { get; set; }

        [JsonProperty("index_id")]
        public string IndexId { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("price_percentage_change_24h")]
        public double? PricePercentageChange24H { get; set; }

        [JsonProperty("contract_type")]
        public string ContractType { get; set; }

        [JsonProperty("index")]
        public double? Index { get; set; }

        [JsonProperty("basis")]
        public double? Basis { get; set; }

        [JsonProperty("spread")]
        public double? Spread { get; set; }

        [JsonProperty("funding_rate")]
        public double? FundingRate { get; set; }

        [JsonProperty("open_interest")]
        public double? OpenInterest { get; set; }

        [JsonProperty("volume_24h")]
        public double? Volume24H { get; set; }

        [JsonProperty("last_traded_at")]
        public long? LastTradedAt { get; set; }

        [JsonProperty("expired_at")]
        public long? ExpiredAt { get; set; }
    }
}