using System.Linq;
using CoinGecko.Clients;
using Xunit;

namespace CoinGecko.Test
{
    public class ExchangeRatesClientTests
    {
        private readonly CoinGeckoClient _client;

        public ExchangeRatesClientTests()
        {
            _client = CoinGeckoClient.Instance;
        }

        [Fact]
        public async void Exchange_Rates_Cointains_Eos()
        {
            var result = await _client.ExchangeRatesClient.GetExchangeRates();
            Assert.True(result.Rates.ContainsKey("eos"));
        }

    }
}