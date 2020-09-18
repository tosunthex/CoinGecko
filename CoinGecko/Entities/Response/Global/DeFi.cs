using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinGecko.Entities.Response.Global
{
    public class DeFi
    {
        [JsonProperty("data")]
        public DeFiData Data { get; set; }
    }

    public class DeFiData
    {
        [JsonProperty("defi_market_cap")]
        public double? DeFiMarketCap { get; set; }

        [JsonProperty("eth_market_cap")]
        public double? EthMarketCap { get; set; }

        [JsonProperty("defi_to_eth_ratio")]
        public double? DefiToEthRatio { get; set; }

        [JsonProperty("trading_volume_24h")]
        public double? TradingVolume24H { get; set; }

        [JsonProperty("defi_dominance")]
        public double? DeFiDominance { get; set; }

        [JsonProperty("top_coin_name")]
        public string TopCoinName { get; set; }

        [JsonProperty("top_coin_defi_dominance")]
        public double? TopCoinDeFiDominance { get; set; }
    }
}
