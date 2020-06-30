using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Indexes
{
    public class IndexList
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}