using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Shared
{
    public class Ticker
    {
        [JsonProperty("base")] public string Base { get; set; }

        [JsonProperty("target")] public string Target { get; set; }

        [JsonProperty("market")] public Market Market { get; set; }

        [JsonProperty("last")] public decimal? Last { get; set; }

        [JsonProperty("cost_to_move_up_usd")] public decimal CostToMoveUpUsd { get; set; }

        [JsonProperty("cost_to_move_down_usd")] public decimal CostToMoveDownUsd { get; set; }

        [JsonProperty("converted_last")] public Dictionary<string, decimal> ConvertedLast { get; set; }

        [JsonProperty("volume")] public decimal? Volume { get; set; }

        [JsonProperty("converted_volume")] public Dictionary<string, decimal> ConvertedVolume { get; set; }

        [JsonProperty("trust_score")] public string TrustScore { get; set; }

        [JsonProperty("timestamp")] public DateTimeOffset? Timestamp { get; set; }

        [JsonProperty("last_traded_at")] public DateTimeOffset? LastTradedAt { get; set; }

        [JsonProperty("last_fetch_at")] public DateTimeOffset? LastFetchAt { get; set; }

        [JsonProperty("is_anomaly", NullValueHandling = NullValueHandling.Ignore)] public bool IsAnomaly { get; set; }

        [JsonProperty("is_stale")] public bool IsStale { get; set; }

        [JsonProperty("trade_url")] public string TradeUrl { get; set; }

        [JsonProperty("coin_id")] public string CoinId { get; set; }
        [JsonProperty("target_coin_id", NullValueHandling = NullValueHandling.Ignore)] public string TargetCoinId { get; set; }
    }
}