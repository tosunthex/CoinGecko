using System.Linq;
using System.Threading.Tasks;
using CoinGecko.Clients;
using CoinGecko.Interfaces;
using Xunit;

namespace CoinGecko.Test
{
    public class ExchangeRatesClientTests
    {
        private readonly ICoinGeckoClient _client;

        public ExchangeRatesClientTests()
        {
            _client = CoinGeckoClient.Instance;
        }

        [Fact]
        public async Task Exchange_Rates_Cointains_Eos()
        {
            var result = await _client.ExchangeRatesClient.GetExchangeRates();
            Assert.True(result.Rates.ContainsKey("eos"));
        }

    }
}