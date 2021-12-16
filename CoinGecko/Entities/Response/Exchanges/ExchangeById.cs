using System;
using CoinGecko.Entities.Response.Shared;
using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Exchanges
{
    public class ExchangeById : Exchanges
    {
        [JsonProperty("tickers")]
        public Ticker[] Tickers { get; set; }

        [JsonProperty("status_updates")]
        public object[] StatusUpdates { get; set; }
        
        [JsonProperty("facebook_url")]
        public string FacebookUrl { get; set; }
        
        [JsonProperty("reddit_url")]
        public string RedditUrl { get; set; }
        
        [JsonProperty("telegram_url")]
        public string TelegramUrl { get; set; }
        
        [JsonProperty("slack_url")]
        public string SlackUrl { get; set; }
        
        [JsonProperty("other_url_1")]
        public string Other1Url { get; set; }
        
        [JsonProperty("other_url_2")]
        public string Other2Url { get; set; }
        
        [JsonProperty("twitter_handle")]
        public string TwitterHandle { get; set; }
        
        [JsonProperty("centralized")]
        public bool? Centralized { get; set; }
        
        [JsonProperty("public_notice")]
        public string PublicNotice { get; set; }
        
        [JsonProperty("alert_notice")]
        public string AlertNotice { get; set; }
    }
}