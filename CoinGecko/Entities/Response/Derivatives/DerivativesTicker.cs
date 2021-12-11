using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Derivatives
{
    public class DerivativesTicker
    {
        [JsonProperty("symbol")] 
        public string Symbol { get; set; }
        
        [JsonProperty("base")] 
        public string Base { get; set; }

        [JsonProperty("target")] 
        public string Target { get; set; }
        
        [JsonProperty("trade_url")] 
        public string TradeUrl { get; set; }
        
        [JsonProperty("contract_type")] 
        public string ContractType { get; set; }
        
        [JsonProperty("last")] 
        public decimal? Last { get; set; }

        [JsonProperty("h24_percentage_change")] 
        public decimal? PricePctChange { get; set; }

        [JsonProperty("index")] 
        public decimal? Index { get; set; }
        
        [JsonProperty("index_basis_percentage")] 
        public decimal? IndexBasisPercentage { get; set; }
        
        [JsonProperty("bid_ask_spread")] 
        public decimal? BidAskSpread { get; set; }
        
        [JsonProperty("funding_rate")] 
        public decimal? FundingRate { get; set; }
        
        [JsonProperty("open_interest_usd")] 
        public decimal? OpenInterestUsd { get; set; }
        
        [JsonProperty("converted_volume")] 
        public Dictionary<string, decimal> ConvertedVolume { get; set; }
        
        [JsonProperty("converted_last")] 
        public Dictionary<string, decimal> ConvertedLast { get; set; }
        
        [JsonProperty("last_traded")] 
        public int? LastTraded { get; set; }
        
        [JsonProperty("expired_at")] 
        public int? ExpiredAt { get; set; }
    }
}