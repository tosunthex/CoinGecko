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
        public async void BTC_To_ETH_Convert_Must_Not_Null()
        {
            var ids = "bitcoin";
            var vs_currencies = "eth";
            var result = await _client.SimpleClient.GetSimplePrice(new []{ids},new []{vs_currencies});
            Assert.False(string.IsNullOrEmpty(result[ids][vs_currencies].Value.ToString()));
        }
        [Fact]
        public async void Supported_Vs_Currencies_Must_Cointains_BTC_ETH()
        {
            var result = await _client.SimpleClient.GetSupportedVsCurrencies();
            
            Assert.True(result.Contains("btc"));
            Assert.True(result.Contains("eth"));
        }
    }
}