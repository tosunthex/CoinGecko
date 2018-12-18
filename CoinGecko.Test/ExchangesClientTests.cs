using System.Linq;
using System.Threading.Tasks;
using CoinGecko.Clients;
using Xunit;

namespace CoinGecko.Test
{
    public class ExchangesClientTests
    {
        private readonly CoinGeckoClient _client;

        public ExchangesClientTests()
        {
            _client = CoinGeckoClient.Instance;
        }

        [Fact]
        public async Task Exchages_Count_Greater_Than_Hundred()
        {
            var result = await _client.ExchangesClient.GetExchages();
            Assert.True(result.Count > 100);
        }
        
        [Fact]
        public async Task Exchages_For_Bitfinex()
        {
            var result = await _client.ExchangesClient.GetExchangesByExchangeId("bitfinex");
            Assert.Equal("Bitfinex",result.Name);
        }

        [Fact]
        public async Task Exchanges_Bitfinex_Tickers()
        {
            var result = await _client.ExchangesClient.GetTickerByExchangeId("bitfinex");
            Assert.Equal("Bitfinex",result.Name);
        }
    }
}