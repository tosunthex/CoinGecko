using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Exchanges
{
    public class ExchangesMain
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("has_trading_incentive")]
        public bool? HasTradingIncentive { get; set; }

        [JsonProperty("trust_score")]
        public double? TrustScore { get; set; }
        
        [JsonProperty("trust_score_rank")]
        public double? TrustScoreRank { get; set; }

        [JsonProperty("trade_volume_24h_btc")]
        public double? TradeVolume24HBtc { get; set; }
        
        [JsonProperty("trade_volume_24h_btc_normalized")]
        public double? TradeVolume24HBtcNormalized { get; set; }
    }
}