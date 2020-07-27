using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Finance
{
    public class FinanceProducts
    {
        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("supply_rate_percentage")]
        public string SupplyRatePercentage { get; set; }

        [JsonProperty("borrow_rate_percentage")]
        public string BorrowRatePercentage { get; set; }

        [JsonProperty("number_duration")]
        public object NumberDuration { get; set; }

        [JsonProperty("length_duration")]
        public object LengthDuration { get; set; }

        [JsonProperty("start_at")]
        public long? StartAt { get; set; }

        [JsonProperty("end_at")]
        public long? EndAt { get; set; }

        [JsonProperty("value_at")]
        public long? ValueAt { get; set; }

        [JsonProperty("redeem_at")]
        public long? RedeemAt { get; set; }
    }
}