using System;
using System.Collections.Generic;
using CoinGecko.Entities.Response.Shared;
using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Coins
{
    public class CoinFullDataById : CoinFullDataWithOutMarketData
    {
        [JsonProperty("block_time_in_minutes")]
        public long? BlockTimeInMinutes { get; set; }

        [JsonProperty("categories")] public string[] Categories { get; set; }

        [JsonProperty("description")] public Dictionary<string, string> Description { get; set; }

        [JsonProperty("links")] public Links Links { get; set; }

        [JsonProperty("country_origin")] public string CountryOrigin { get; set; }

        [JsonProperty("genesis_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset GenesisDate { get; set; }

        [JsonProperty("market_cap_rank")] public long? MarketCapRank { get; set; }

        [JsonProperty("coingecko_rank")] public long? CoinGeckoRank { get; set; }

        [JsonProperty("coingecko_score")] public double? CoinGeckoScore { get; set; }

        [JsonProperty("developer_score")] public double? DeveloperScore { get; set; }

        [JsonProperty("community_score")] public double? CommunityScore { get; set; }

        [JsonProperty("liquidity_score")] public double? LiquidityScore { get; set; }

        [JsonProperty("public_interest_score")]
        public double? PublicInterestScore { get; set; }

        [JsonProperty("market_data", NullValueHandling = NullValueHandling.Ignore)]
        public CoinByIdMarketData MarketData { get; set; }

        [JsonProperty("status_updates")] public object[] StatusUpdates { get; set; }

        [JsonProperty("tickers")] public Ticker[] Tickers { get; set; }
    }

    public class CommunityData
    {
        [JsonProperty("facebook_likes")] public double? FacebookLikes { get; set; }

        [JsonProperty("twitter_followers")] public double? TwitterFollowers { get; set; }

        [JsonProperty("reddit_average_posts_48h")]
        public double? RedditAveragePosts48H { get; set; }

        [JsonProperty("reddit_average_comments_48h")]
        public double? RedditAverageComments48H { get; set; }

        [JsonProperty("reddit_subscribers")] public double? RedditSubscribers { get; set; }

        [JsonProperty("reddit_accounts_active_48h")]
        public double? RedditAccountsActive48H { get; set; }

        [JsonProperty("telegram_channel_user_count")]
        public double? TelegramChannelUserCount { get; set; }
    }

    public class ReposUrl
    {
        [JsonProperty("github")] public Uri[] Github { get; set; }

        [JsonProperty("bitbucket")] public object[] Bitbucket { get; set; }
    }

    public class CoinByIdMarketData : MarketData
    {
        [JsonProperty("ath")] public Dictionary<string, double> Ath { get; set; }

        [JsonProperty("ath_change_percentage")]
        public Dictionary<string, double> AthChangePercentage { get; set; }

        [JsonProperty("ath_date")] public Dictionary<string, DateTimeOffset> AthDate { get; set; }

        [JsonProperty("sparkline_7d", NullValueHandling = NullValueHandling.Ignore)]
        public SparklineIn7D Sparkline7D { get; set; }

        [JsonProperty("last_updated")] public DateTimeOffset LastUpdated { get; set; }
    }
}