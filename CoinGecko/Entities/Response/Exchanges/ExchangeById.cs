using CoinGecko.Entities.Response.Coins;
using CoinGecko.Entities.Response.Shared;
using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Exchanges
{
    public class ExchangeById:ExchangesMain
    {
        [JsonProperty("tickers")]
        public Ticker[] Tickers { get; set; }

        [JsonProperty("status_updates")]
        public object[] StatusUpdates { get; set; }
    }
    
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