using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Coins
{
    public class SparklineIn7D
    {
        [JsonProperty("price")]
        public double[] Price { get; set; }
    }
}