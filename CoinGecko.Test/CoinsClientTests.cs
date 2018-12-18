using System.Linq;
using System.Threading.Tasks;
using CoinGecko.Clients;
using Xunit;

namespace CoinGecko.Test
{
    public class CoinsClientTests
    {
        private readonly CoinGeckoClient _client;
        public CoinsClientTests()
        {
            _client = CoinGeckoClient.Instance;
        }
        
        [Fact]
        public async Task Market_Chart()
        {
            var result = await _client.CoinsClient.GetMarketChartsByCoinId("bitcoin", new []{"usd"}, "1");
            Assert.Equal(result.Prices.Length,result.MarketCaps.Length);
        }

        [Fact]
        public async Task CoinsLists_Must_Not_Null_And_First_Element_Must_BTC()
        {
            var result = await _client.CoinsClient.GetCoinList();
            Assert.Equal("bitcoin",result.First().Id);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task Coin_By_Id_Must_Return_BTC()
        {
            var result = await _client.CoinsClient.GetAllCoinDataWithId("bitcoin");
            Assert.Equal("btc",result.Symbol);
            result = await _client.CoinsClient.GetAllCoinDataWithId("bitcoin","false",true,false,false,false,true);
            Assert.Equal("btc",result.Symbol);
        }

        [Fact]
        public async Task Coin_Stellar_Tickers()
        {
            var result = await _client.CoinsClient.GetTickerByCoinId("stellar");
            Assert.Equal("Stellar",result.Name);
        }

        [Fact]
        public async Task Coin_Tether_History()
        {
            var result = await _client.CoinsClient.GetHistoryByCoinId("tether","01-12-2018","false");
            Assert.Equal("Tether",result.Name);
        }

        [Fact]
        public async Task Coin_Stellar_Market_Chart_Price_Lenght_Must_Equal_to_Marketcaps_Lenght()
        {
            var result = await _client.CoinsClient.GetMarketChartsByCoinId("stellar", new[] {"usd"}, "2");
            Assert.Equal(result.Prices.Length,result.MarketCaps.Length);
        }
    }
}