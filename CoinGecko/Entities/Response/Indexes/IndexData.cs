using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Indexes
{
    public class IndexData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("market")]
        public string Market { get; set; }

        [JsonProperty("last")]
        public double? Last { get; set; }

        [JsonProperty("is_multi_asset_composite")]
        public bool? IsMultiAssetComposite { get; set; }
    }
}