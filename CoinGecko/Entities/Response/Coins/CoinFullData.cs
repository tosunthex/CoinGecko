using System;
using System.Collections.Generic;
using CoinGecko.Entities.Response.Shared;
using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Coins
{
    public class CoinFullData : CoinFullDataWithOutMarketData
    {
        [JsonProperty("market_data", NullValueHandling = NullValueHandling.Ignore)]
        public MarketData MarketData { get; set; }
    }

    public class CoinFullDataWithOutMarketData : CoinList
    {
        [JsonProperty("image")] public Image Image { get; set; }

        [JsonProperty("community_data", NullValueHandling = NullValueHandling.Ignore)]
        public CommunityData CommunityData { get; set; }

        [JsonProperty("developer_data", NullValueHandling = NullValueHandling.Ignore)]
        public DeveloperData DeveloperData { get; set; }

        [JsonProperty("public_interest_stats", NullValueHandling = NullValueHandling.Ignore)]
        public PublicInterestStats PublicInterestStats { get; set; }

        [JsonProperty("last_updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastUpdated { get; set; }

        [JsonProperty("localization", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Localization { get; set; }
    }

    public class DeveloperData
    {
        [JsonProperty("forks")] public long? Forks { get; set; }

        [JsonProperty("stars")] public long? Stars { get; set; }

        [JsonProperty("subscribers")] public long? Subscribers { get; set; }

        [JsonProperty("total_issues")] public long? TotalIssues { get; set; }

        [JsonProperty("closed_issues")] public long? ClosedIssues { get; set; }

        [JsonProperty("pull_requests_merged")] public long? PullRequestsMerged { get; set; }

        [JsonProperty("pull_request_contributors")]
        public long? PullRequestContributors { get; set; }

        [JsonProperty("code_additions_deletions_4_weeks", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,long?> CodeAdditionsDeletions4Weeks { get; set; }
    
        [JsonProperty("commit_count_4_weeks")] public long? CommitCount4Weeks { get; set; }
        
        [JsonProperty("last_4_weeks_commit_activity_series", NullValueHandling = NullValueHandling.Ignore)] 
        public long[] Last4WeeksCommitActivitySeries { get;set; }
    }

    public class MarketData : MarketDataOhlcv
    {
        [JsonProperty("roi")] public Roi Roi { get; set; }

        [JsonProperty("current_price")] public Dictionary<string, decimal?> CurrentPrice { get; set; }

        [JsonProperty("market_cap")] public Dictionary<string, decimal?> MarketCap { get; set; }

        [JsonProperty("total_volume")] public Dictionary<string, decimal?> TotalVolume { get; set; }

        [JsonProperty("high_24h")] public Dictionary<string, decimal?> High24H { get; set; }

        [JsonProperty("low_24h")] public Dictionary<string, decimal?> Low24H { get; set; }

        [JsonProperty("price_change_percentage_7d")]
        public string PriceChangePercentage7D { get; set; }

        [JsonProperty("price_change_percentage_14d")]
        public string PriceChangePercentage14D { get; set; }

        [JsonProperty("price_change_percentage_30d")]
        public string PriceChangePercentage30D { get; set; }

        [JsonProperty("price_change_percentage_60d")]
        public string PriceChangePercentage60D { get; set; }

        [JsonProperty("price_change_percentage_200d")]
        public string PriceChangePercentage200D { get; set; }

        [JsonProperty("price_change_percentage_1y")]
        public string PriceChangePercentage1Y { get; set; }

        [JsonProperty("price_change_24h_in_currency")]
        public Dictionary<string, decimal> PriceChange24HInCurrency { get; set; }

        [JsonProperty("price_change_percentage_1h_in_currency")]
        public Dictionary<string, double> PriceChangePercentage1HInCurrency { get; set; }

        [JsonProperty("price_change_percentage_24h_in_currency")]
        public Dictionary<string, double> PriceChangePercentage24HInCurrency { get; set; }

        [JsonProperty("price_change_percentage_7d_in_currency")]
        public Dictionary<string, double> PriceChangePercentage7DInCurrency { get; set; }

        [JsonProperty("price_change_percentage_14d_in_currency")]
        public Dictionary<string, double> PriceChangePercentage14DInCurrency { get; set; }

        [JsonProperty("price_change_percentage_30d_in_currency")]
        public Dictionary<string, double> PriceChangePercentage30DInCurrency { get; set; }

        [JsonProperty("price_change_percentage_60d_in_currency")]
        public Dictionary<string, double> PriceChangePercentage60DInCurrency { get; set; }

        [JsonProperty("price_change_percentage_200d_in_currency")]
        public Dictionary<string, double> PriceChangePercentage200DInCurrency { get; set; }

        [JsonProperty("price_change_percentage_1y_in_currency")]
        public Dictionary<string, double> PriceChangePercentage1YInCurrency { get; set; }

        [JsonProperty("market_cap_change_24h_in_currency")]
        public Dictionary<string, decimal> MarketCapChange24HInCurrency { get; set; }

        [JsonProperty("market_cap_change_percentage_24h_in_currency")]
        public Dictionary<string, decimal> MarketCapChangePercentage24HInCurrency { get; set; }
    }

    public class Roi
    {
        [JsonProperty("times")] public decimal? Times { get; set; }

        [JsonProperty("currency")] public string Currency { get; set; }

        [JsonProperty("percentage")] public decimal? Percentage { get; set; }
    }
}