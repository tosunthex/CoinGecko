using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinGecko.Entities.Response.Global
{
    public class GlobalDeFi
    {
        [JsonProperty("data")]
        public GlobalDeFiData Data { get; set; }
    }

    public class GlobalDeFiData
    {
        [JsonProperty("defi_market_cap")]
        public decimal? DeFiMarketCap { get; set; }

        [JsonProperty("eth_market_cap")]
        public decimal? EthMarketCap { get; set; }

        [JsonProperty("defi_to_eth_ratio")]
        public decimal? DefiToEthRatio { get; set; }

        [JsonProperty("trading_volume_24h")]
        public decimal? TradingVolume24H { get; set; }

        [JsonProperty("defi_dominance")]
        public decimal? DeFiDominance { get; set; }

        [JsonProperty("top_coin_name")]
        public string TopCoinName { get; set; }

        [JsonProperty("top_coin_defi_dominance")]
        public decimal? TopCoinDeFiDominance { get; set; }
    }
}
