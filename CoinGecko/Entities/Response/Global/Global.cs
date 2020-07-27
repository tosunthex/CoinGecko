using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Global
{
    public class Global
    {
        [JsonProperty("data")]
        public GlobalData Data { get; set; }
    }

    public class GlobalData
    {
        [JsonProperty("active_cryptocurrencies")]
        public long? ActiveCryptocurrencies { get; set; }

        [JsonProperty("upcoming_icos")]
        public long? UpcomingIcos { get; set; }

        [JsonProperty("ongoing_icos")]
        public long? OngoingIcos { get; set; }

        [JsonProperty("ended_icos")]
        public long? EndedIcos { get; set; }

        [JsonProperty("markets")]
        public long? Markets { get; set; }

        [JsonProperty("total_market_cap")]
        public Dictionary<string, double> TotalMarketCap { get; set; }

        [JsonProperty("total_volume")]
        public Dictionary<string, double> TotalVolume { get; set; }

        [JsonProperty("market_cap_percentage")]
        public Dictionary<string, double> MarketCapPercentage { get; set; }

        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}