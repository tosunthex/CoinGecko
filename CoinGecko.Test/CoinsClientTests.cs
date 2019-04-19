using System.Linq;
using System.Threading.Tasks;
using CoinGecko.Clients;
using CoinGecko.Entities.Response.Coins;
using CoinGecko.Interfaces;
using Xunit;

namespace CoinGecko.Test
{
    public class CoinsClientTests
    {
        private readonly ICoinGeckoClient _client;
        public CoinsClientTests()
        {
            _client = CoinGeckoClient.Instance;
        }
        
        [Fact]
        public async Task All_Coins_Data()
        {
            var coinList = await _client.CoinsClient.GetCoinList();
            var result = await _client.CoinsClient.GetAllCoinsData("",coinList.Count,null,"",null);
            Assert.NotNull(result);
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
        public async Task Coin_by_Id_Must_Contains_ATH_Details()
        {
            var result = await _client.CoinsClient.GetAllCoinDataWithId("bitcoin");
            Assert.NotNull(result.MarketData.Ath);
            Assert.NotNull(result.MarketData.AthDate);
            Assert.NotNull(result.MarketData.AthChangePercentage);
        }
        
        [Fact]
        public async Task Hydro_Genesis_Date_Equal_To_Null()
        {
            var result = await _client.CoinsClient.GetAllCoinDataWithId("hydro");
            Assert.NotNull(result.MarketData.Ath);
        }

        [Fact]
        public async Task Coin_Stellar_Tickers()
        {
            var result = await _client.CoinsClient.GetTickerByCoinId("stellar");
            Assert.Equal("Stellar",result.Name);
        }
        
        [Fact]
        public async Task Coin_Stellar_Tickers_For_Binance_And_Bitfinex()
        {
            var result = await _client.CoinsClient.GetTickerByCoinId("stellar",new []{"binance","bitfinex"},null);
            Assert.Equal("Stellar",result.Name);
            Assert.Equal("Binance",result.Tickers[0].Market.Name);
            Assert.Equal("Bitfinex",result.Tickers.LastOrDefault().Market.Name);
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

        [Fact]
        public async Task Coin_Markets_VsCurrency_For_USD()
        {
            var result = await _client.CoinsClient.GetCoinMarkets("usd");
            Assert.Equal(100,result.Count);
        }

        [Fact]
        public async Task Coin_Markets_VsCurrency_For_USD_Bitcoin_Roi_Null()
        {
            var result = await _client.CoinsClient.GetCoinMarkets("usd");
            Assert.Equal(100, result.Count);
            var roiEth = result.Find(x => x.Id == "ethereum").Roi;
            var roiBtc = result.Find(x => x.Id == "bitcoin").Roi;
            Assert.NotNull(roiEth);
            Assert.Null(roiBtc);
        }

        [Fact]
        public async Task Price_Change_Percentage_By_Days_Must_Not_Null()
        {
            var result = await _client.CoinsClient.GetCoinMarkets("usd", new []{"bitcoin"}, null, null, null, false, "1h,24h,7d,14d,30d,200d,1y");
            Assert.NotNull(result.First().PriceChangePercentage1HInCurrency);
            Assert.NotNull(result.First().PriceChangePercentage24HInCurrency);
            Assert.NotNull(result.First().PriceChangePercentage7DInCurrency);
            Assert.NotNull(result.First().PriceChangePercentage14DInCurrency);
            Assert.NotNull(result.First().PriceChangePercentage30DInCurrency);
            Assert.NotNull(result.First().PriceChangePercentage200DInCurrency);
            Assert.NotNull(result.First().PriceChangePercentage1YInCurrency);
        }
        
        [Fact]
        public async Task Price_Change_Percentage_By_Days_Must_Null()
        {
            var result = await _client.CoinsClient.GetCoinMarkets("usd", new []{"bitcoin"}, null, null, null, false,null);
            Assert.Null(result.First().PriceChangePercentage1HInCurrency);
            Assert.Null(result.First().PriceChangePercentage24HInCurrency);
            Assert.Null(result.First().PriceChangePercentage7DInCurrency);
            Assert.Null(result.First().PriceChangePercentage14DInCurrency);
            Assert.Null(result.First().PriceChangePercentage30DInCurrency);
            Assert.Null(result.First().PriceChangePercentage200DInCurrency);
            Assert.Null(result.First().PriceChangePercentage1YInCurrency);
        }
    }
}