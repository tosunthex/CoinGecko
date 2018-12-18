using System.Threading.Tasks;
using CoinGecko.Clients;
using Xunit;

namespace CoinGecko.Test
{
    public class SimpleClientTests
    {
        private readonly CoinGeckoClient _client;
        public SimpleClientTests()
        {
            _client = CoinGeckoClient.Instance;
        }
        [Fact]
        public async Task BTC_To_ETH_Convert_Must_Not_Null()
        {
            const string ids = "bitcoin";
            const string vsCurrencies = "eth";
            var result = await _client.SimpleClient.GetSimplePrice(new []{ids},new []{vsCurrencies});
            Assert.False(string.IsNullOrEmpty(result[ids][vsCurrencies]?.ToString()));
        }
        [Fact]
        public async Task Supported_Vs_Currencies_Must_Cointains_BTC_ETH()
        {
            var result = await _client.SimpleClient.GetSupportedVsCurrencies();
            
            Assert.Contains("btc", result);
            Assert.Contains("eth", result);
        }
    }
}