using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Shared
{
    public class PublicInterestStats
    {
        [JsonProperty("alexa_rank")] public long? AlexaRank { get; set; }

        [JsonProperty("bing_matches")] public long? BingMatches { get; set; }
    }
}