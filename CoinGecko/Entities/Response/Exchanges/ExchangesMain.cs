using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Exchanges
{
    public class ExchangesMain
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("has_trading_incentive")]
        public bool? HasTradingIncentive { get; set; }

        [JsonProperty("trade_volume_24h_btc")]
        public double? TradeVolume24HBtc { get; set; }
    }
}