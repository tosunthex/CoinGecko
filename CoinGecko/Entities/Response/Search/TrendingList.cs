using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Search
{
    public class TrendingList
    {
        [JsonProperty("coins")]
        public TrendingItemWrapper[] TrendingItems { get; set; }

        // It's unknown what kind of data contains "exchanges" because
        // CoinGecko API return empty list, so using object[] declaration
        [JsonProperty("exchanges")]
        public object[] Exchanges { get; set; }
    }
}
