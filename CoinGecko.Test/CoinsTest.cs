using System.Net.Http;
using CoinGecko.Clients;
using Xunit;

namespace CoinGecko.Test
{
    public class CoinsTest
    {
        private readonly CoinGeckoClient _client;
        public CoinsTest()
        {
            _client = new CoinGeckoClient(new HttpClientHandler());
        }

        [Fact]
        public async void Market_Chart()
        {
            var result = _client.CoinsClient.GetMarketChartsByCoinId("bitcoin", new []{"usd"}, "1");
            Assert.Equal(result.Result.Prices.Length,result.Result.MarketCaps.Length);
        } 
    }
}