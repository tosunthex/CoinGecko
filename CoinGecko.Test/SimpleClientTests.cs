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

        [Fact]
        public async Task Token_Price_for_Vs_Currencies_BTC_ETH()
        {
            var result = await _client.SimpleClient.GetTokenPrice("ethereum", new []{ "0xa0b86991c6218b36c1d19d4a2e9eb0ce3606eb48,0xb6ed7644c69416d67b522e20bc294a9a9b405b31" },new []{ "btc,eth" }
            ,true,true,true,true);
            Assert.NotNull(result);
        }
    }
}