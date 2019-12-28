using System;
using System.Collections.Generic;
using CoinGecko.Entities.Response.Shared;
using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Coins
{
    public class CoinFullDataById : CoinFullDataWithOutMarketData
    {
        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("description")]
        public Dictionary<string,string> Description { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("country_origin")]
        public string CountryOrigin { get; set; }

        [JsonProperty("genesis_date",NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset GenesisDate { get; set; }

        [JsonProperty("market_cap_rank")]
        public long? MarketCapRank { get; set; }

        [JsonProperty("coingecko_rank")]
        public long? CoinGeckoRank { get; set; }

        [JsonProperty("coingecko_score")]
        public double? CoinGeckoScore { get; set; }

        [JsonProperty("developer_score")]
        public double? DeveloperScore { get; set; }

        [JsonProperty("community_score")]
        public double? CommunityScore { get; set; }

        [JsonProperty("liquidity_score")]
        public double? LiquidityScore { get; set; }

        [JsonProperty("public_interest_score")]
        public double? PublicInterestScore { get; set; }
        
        [JsonProperty("market_data",NullValueHandling = NullValueHandling.Ignore)]
        public CoinByIdMarketData MarketData { get; set; }
        
        [JsonProperty("status_updates")]
        public object[] StatusUpdates { get; set; }

        [JsonProperty("tickers")]
        public Ticker[] Tickers { get; set; }
    }

    public class CommunityData
    {
        [JsonProperty("facebook_likes")]
        public long? FacebookLikes { get; set; }

        [JsonProperty("twitter_followers")]
        public long? TwitterFollowers { get; set; }

        [JsonProperty("reddit_average_posts_48h")]
        public long? RedditAveragePosts48H { get; set; }

        [JsonProperty("reddit_average_comments_48h")]
        public long? RedditAverageComments48H { get; set; }

        [JsonProperty("reddit_subscribers")]
        public long? RedditSubscribers { get; set; }

        [JsonProperty("reddit_accounts_active_48h")]
        public long? RedditAccountsActive48H { get; set; }

        [JsonProperty("telegram_channel_user_count")]
        public long? TelegramChannelUserCount { get; set; }
    }

    public class Links
    {
        [JsonProperty("homepage")]
        public string[] Homepage { get; set; }

        [JsonProperty("blockchain_site")]
        public string[] BlockchainSite { get; set; }

        [JsonProperty("official_forum_url")]
        public string[] OfficialForumUrl { get; set; }

        [JsonProperty("chat_url")]
        public string[] ChatUrl { get; set; }

        [JsonProperty("announcement_url")]
        public string[] AnnouncementUrl { get; set; }

        [JsonProperty("twitter_screen_name")]
        public string TwitterScreenName { get; set; }

        [JsonProperty("facebook_username")]
        public string FacebookUsername { get; set; }

        [JsonProperty("bitcointalk_thread_identifier")]
        public object BitcointalkThreadIdentifier { get; set; }

        [JsonProperty("telegram_channel_identifier")]
        public string TelegramChannelIdentifier { get; set; }

        [JsonProperty("subreddit_url")]
        public Uri SubredditUrl { get; set; }

        [JsonProperty("repos_url")]
        public ReposUrl ReposUrl { get; set; }
    }

    public class ReposUrl
    {
        [JsonProperty("github")]
        public Uri[] Github { get; set; }

        [JsonProperty("bitbucket")]
        public object[] Bitbucket { get; set; }
    }

    public class CoinByIdMarketData:MarketData
    {
        [JsonProperty("ath")]
        public Dictionary<string, double> Ath { get; set; }

        [JsonProperty("ath_change_percentage")]
        public Dictionary<string, double> AthChangePercentage { get; set; }

        [JsonProperty("ath_date")]
        public Dictionary<string, DateTimeOffset> AthDate { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset? LastUpdated { get; set; }
    }
}