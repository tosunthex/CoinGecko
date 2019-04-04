using System.Threading.Tasks;
using CoinGecko.Clients;
using CoinGecko.Interfaces;
using Xunit;

namespace CoinGecko.Test
{
    public class SimpleClientTests
    {
        private readonly ICoinGeckoClient _client;
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
        public async Task Market_Cap_And_24H_Change_NotNull()
        {
            const string ids = "bitcoin";
            const string vsCurrencies = "eth,xrp";
            var result = await _client.SimpleClient.GetSimplePrice(new []{ids},new []{vsCurrencies},true,false,true,false);
            Assert.True(result["bitcoin"].ContainsKey("eth_market_cap"));
            Assert.True(result["bitcoin"].ContainsKey("xrp_24h_change"));
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