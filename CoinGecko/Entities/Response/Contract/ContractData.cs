using System;
using System.Collections.Generic;
using System.Globalization;
using CoinGecko.Entities.Response.Coins;
using CoinGecko.Entities.Response.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CoinGecko.Entities.Response.Contract
{
    public class ContractData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("asset_platform_id")]
        public string AssetPlatformId { get; set; }

        [JsonProperty("block_time_in_minutes")]
        public long? BlockTimeInMinutes { get; set; }

        [JsonProperty("hashing_algorithm")]
        public object HashingAlgorithm { get; set; }

        [JsonProperty("categories")]
        public object[] Categories { get; set; }

        [JsonProperty("localization")]
        public Dictionary<string, string> Localization { get; set; }

        [JsonProperty("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("country_origin")]
        public string CountryOrigin { get; set; }

        [JsonProperty("genesis_date")]
        public DateTimeOffset? GenesisDate { get; set; }

        [JsonProperty("contract_address")]
        public string ContractAddress { get; set; }

        [JsonProperty("sentiment_votes_up_percentage")]
        public double? SentimentVotesUpPercentage { get; set; }

        [JsonProperty("sentiment_votes_down_percentage")]
        public double? SentimentVotesDownPercentage { get; set; }

        [JsonProperty("ico_data")]
        public IcoData IcoData { get; set; }

        [JsonProperty("market_cap_rank")] public long? MarketCapRank { get; set; }

        [JsonProperty("coingecko_rank")] public long? CoinGeckoRank { get; set; }

        [JsonProperty("coingecko_score")] public double? CoinGeckoScore { get; set; }

        [JsonProperty("developer_score")] public double? DeveloperScore { get; set; }

        [JsonProperty("community_score")] public double? CommunityScore { get; set; }

        [JsonProperty("liquidity_score")] public double? LiquidityScore { get; set; }

        [JsonProperty("public_interest_score")] public double? PublicInterestScore { get; set; }

        [JsonProperty("market_data")]
        public MarketData MarketData { get; set; }

        [JsonProperty("community_data")]
        public CommunityData CommunityData { get; set; }

        [JsonProperty("developer_data")]
        public DeveloperData DeveloperData { get; set; }

        [JsonProperty("public_interest_stats")]
        public PublicInterestStats PublicInterestStats { get; set; }

        [JsonProperty("status_updates")]
        public object[] StatusUpdates { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset? LastUpdated { get; set; }

        [JsonProperty("tickers")]
        public Ticker[] Tickers { get; set; }
    }
    public partial class IcoData
    {
        [JsonProperty("ico_start_date")]
        public DateTimeOffset? IcoStartDate { get; set; }

        [JsonProperty("ico_end_date")]
        public DateTimeOffset? IcoEndDate { get; set; }

        [JsonProperty("short_desc")]
        public string ShortDesc { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("links")]
        public IcoDataLinks Links { get; set; }

        [JsonProperty("softcap_currency")]
        public string SoftcapCurrency { get; set; }

        [JsonProperty("hardcap_currency")]
        public string HardcapCurrency { get; set; }

        [JsonProperty("total_raised_currency")]
        public string TotalRaisedCurrency { get; set; }

        [JsonProperty("softcap_amount")]
        public object SoftcapAmount { get; set; }

        [JsonProperty("hardcap_amount")]
        public object HardcapAmount { get; set; }

        [JsonProperty("total_raised")]
        public object TotalRaised { get; set; }

        [JsonProperty("quote_pre_sale_currency")]
        public string QuotePreSaleCurrency { get; set; }

        [JsonProperty("base_pre_sale_amount")]
        public object BasePreSaleAmount { get; set; }

        [JsonProperty("quote_pre_sale_amount")]
        public object QuotePreSaleAmount { get; set; }

        [JsonProperty("quote_public_sale_currency")]
        public string QuotePublicSaleCurrency { get; set; }

        [JsonProperty("base_public_sale_amount")]
        public long? BasePublicSaleAmount { get; set; }

        [JsonProperty("quote_public_sale_amount")]
        public long? QuotePublicSaleAmount { get; set; }

        [JsonProperty("accepting_currencies")]
        public string AcceptingCurrencies { get; set; }

        [JsonProperty("country_origin")]
        public string CountryOrigin { get; set; }

        [JsonProperty("pre_sale_start_date")]
        public object PreSaleStartDate { get; set; }

        [JsonProperty("pre_sale_end_date")]
        public object PreSaleEndDate { get; set; }

        [JsonProperty("whitelist_url")]
        public string WhitelistUrl { get; set; }

        [JsonProperty("whitelist_start_date")]
        public object WhitelistStartDate { get; set; }

        [JsonProperty("whitelist_end_date")]
        public object WhitelistEndDate { get; set; }

        [JsonProperty("bounty_detail_url")]
        public string BountyDetailUrl { get; set; }

        [JsonProperty("amount_for_sale")]
        public object AmountForSale { get; set; }

        [JsonProperty("kyc_required")]
        public bool KycRequired { get; set; }

        [JsonProperty("whitelist_available")]
        public object WhitelistAvailable { get; set; }

        [JsonProperty("pre_sale_available")]
        public object PreSaleAvailable { get; set; }

        [JsonProperty("pre_sale_ended")]
        public bool PreSaleEnded { get; set; }
    }
    public partial class IcoDataLinks
    {
        [JsonProperty("web")]
        public Uri Web { get; set; }

        [JsonProperty("blog")]
        public string Blog { get; set; }

        [JsonProperty("github")]
        public string Github { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("telegram")]
        public string Telegram { get; set; }

        [JsonProperty("whitepaper")]
        public Uri Whitepaper { get; set; }
    }
}
