using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoinGecko.Clients;
using CoinGecko.Entities.Response.Coins;
using CoinGecko.Interfaces;
using CoinGecko.Parameters;
using Xunit;

namespace CoinGecko.Test
{
    public class CoinsClientTests
    {
        private readonly Task<Entities.Response.Coins.CoinFullDataById> _allCoinDataBitCoin;
        private readonly Task<Entities.Response.Coins.CoinFullDataById> _allCoinDataBitCoinWithParameter;
        public CoinsClientTests()
        {
            _client = CoinGeckoClient.Instance;
            _allCoinDataBitCoin = GetAllCoinDataForBtc();
            _allCoinDataBitCoinWithParameter = GetAllCoinDataWithParameterForBtc();
        }

        
        private readonly ICoinGeckoClient _client;

        private async Task<CoinFullDataById> GetAllCoinDataForBtc()
        {
            return await _client.CoinsClient.GetAllCoinDataWithId("bitcoin");
        }
        private async Task<CoinFullDataById> GetAllCoinDataWithParameterForBtc()
        {
            return await _client.CoinsClient.GetAllCoinDataWithId("bitcoin", "false", false, true, false, false, true);
        }
/*
        [Fact]
        public async Task All_Coins_Data()
        {
            var coinList = await _client.CoinsClient.GetCoinList();
            var result = await _client.CoinsClient.GetAllCoinsData("", coinList.Count, null, "", null);
            Assert.NotNull(result);
        }
*/
        [Fact]
        public async Task Bitcoin_Sparkline7d_Equal_To_Null()
        {
            var result = await _allCoinDataBitCoinWithParameter.ConfigureAwait(false);
            Assert.IsType<double[]>(result.MarketData.Sparkline7D.Price);
        }

        [Fact]
        public async Task BTC_Block_Time_in_Minutes_Not_Null()
        {
            var result = await _allCoinDataBitCoin.ConfigureAwait(false);
            Assert.IsType<long>(result.BlockTimeInMinutes);
        }

        [Fact]
        public async Task BTC_Coin_by_Id_Ticker_Must_Contains_trade_URL()
        {
            var result = await _allCoinDataBitCoin.ConfigureAwait(false);
            Assert.IsType<string>(result.Tickers.First().TradeUrl);
        }

        [Fact]
        public async Task Coin_by_Id_Must_Contains_ATH_Details()
        {
            var result = await _allCoinDataBitCoin.ConfigureAwait(false);
            Assert.NotNull(result.MarketData.Ath);
            Assert.NotNull(result.MarketData.AthDate);
            Assert.NotNull(result.MarketData.AthChangePercentage);
        }

        [Fact]
        public async Task Coin_by_Id_Must_Contains_ATL_Details()
        {
            var result = await _allCoinDataBitCoin.ConfigureAwait(false);
            Assert.NotNull(result.MarketData.Atl);
            Assert.NotNull(result.MarketData.AtlDate);
            Assert.NotNull(result.MarketData.AtlChangePercentage);
        }

        [Fact]
        public async Task Coin_By_Id_Must_Return_BTC()
        {
            var result = await _allCoinDataBitCoin.ConfigureAwait(false);
            Assert.Equal("btc", result.Symbol);
            result = await _allCoinDataBitCoinWithParameter.ConfigureAwait(false); 
            Assert.Equal("btc", result.Symbol);
        }

        [Fact]
        public async Task Coin_History_Name_Must_Equal_To_List_Name()
        {
            var coinList = await _client.CoinsClient.GetCoinList();
            for (var i = 0; i < 20; ++i)
            {
                var result = await _client.CoinsClient.GetHistoryByCoinId(coinList[i].Id, "01-12-2018", "false");
                Assert.Equal(coinList[i].Name, result.Name);
            }
        }

        [Fact]
        public async Task Coin_Markets_VsCurrency_For_USD()
        {
            var result = await _client.CoinsClient.GetCoinMarkets("usd");
            Assert.Equal(100, result.Count);
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

        /*[Fact]
        public async Task Coin_Markets_VsCurrency_For_USD_Ripple_Sparkline_Not_Null()
        {
            var result = await _client.CoinsClient.GetCoinMarkets("usd", new[] {"ripple"}, OrderField.MarketCapDesc, 1,
                1, true, "1h");
            Assert.Single(result);
            Assert.Equal("ripple", result[0].Id);
            Assert.NotNull(result[0].SparklineIn7D.Price);
        }*/

        [Fact]
        public async Task Coin_Markets_VsCurrency_For_USD_Ripple_Sparkline_Null()
        {
            var result = await _client.CoinsClient.GetCoinMarkets("usd", new[] {"ripple"}, OrderField.MarketCapDesc, 1,
                1, false, "1h");
            Assert.Single(result);
            Assert.Equal("ripple", result[0].Id);
            Assert.Null(result[0].SparklineIn7D);
        }

        [Fact]
        public async Task Coin_Stellar_Market_Chart_Price_Lenght_Must_Equal_to_Marketcaps_Lenght()
        {
            var result = await _client.CoinsClient.GetMarketChartsByCoinId("stellar", "usd", "2");
            Assert.Equal(result.Prices.Length, result.MarketCaps.Length);
        }

        [Fact]
        public async Task Coin_Stellar_Tickers()
        {
            var result = await _client.CoinsClient.GetTickerByCoinId("stellar");
            Assert.Equal("Stellar", result.Name);
        }

        [Fact]
        public async Task Coin_Stellar_Tickers_For_Binance_And_Bitfinex()
        {
            var result = await _client.CoinsClient.GetTickerByCoinId("stellar", new[] {"binance", "bitfinex"}, null);
            Assert.Equal("Stellar", result.Name);
            var exchangeList = result.Tickers.LastOrDefault()?.Market.Name + " " + result.Tickers[0].Market.Name;
            Assert.Contains("Binance", exchangeList);
            Assert.Contains("Bitfinex", exchangeList);
        }

        [Fact]
        public async Task Coin_Tether_History()
        {
            var result = await _client.CoinsClient.GetHistoryByCoinId("tether", "01-12-2018", "false");
            Assert.Equal("Tether", result.Name);
        }

        [Fact]
        public async Task CoinsLists_Must_Not_Null_And_First_Element_Must_BTC()
        {
            var result = await _client.CoinsClient.GetCoinList();
            Assert.NotNull(result);
        }

        [Fact]
        public async Task Hydro_Genesis_Date_Equal_To_Null()
        {
            var result = await _client.CoinsClient.GetAllCoinDataWithId("hydro");
            Assert.NotNull(result.MarketData.Ath);
        }

        [Fact]
        public async Task Last_Traded_At_and_Last_Fecth_at_Day_Must_Equal_Now()
        {
            var result = await _client.CoinsClient.GetTickerByCoinId("bitcoin");
            Assert.Equal(0, (result.Tickers[0].LastFetchAt - DateTimeOffset.Now).Days);
            Assert.Equal(0, (result.Tickers[0].LastTradedAt - DateTimeOffset.Now).Days);
        }

        [Fact]
        public async Task Market_Chart_Range()
        {
            var result = await _client.CoinsClient.GetMarketChartRangeByCoinId("bitcoin", "usd", "1392577232", "1422577232");
            Assert.Equal(result.Prices.Length, result.MarketCaps.Length);
        }

        [Fact]
        public async Task Price_Change_Percentage_By_Days_Must_Not_Null()
        {
            var result = await _client.CoinsClient.GetCoinMarkets("usd", new[] {"bitcoin"}, null, null, null, false,
                "1h,24h,7d,14d,30d,200d,1y");
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
            var result =
                await _client.CoinsClient.GetCoinMarkets("usd", new[] {"bitcoin"}, null, null, null, false, null);
            Assert.Null(result.First().PriceChangePercentage1HInCurrency);
            Assert.Null(result.First().PriceChangePercentage24HInCurrency);
            Assert.Null(result.First().PriceChangePercentage7DInCurrency);
            Assert.Null(result.First().PriceChangePercentage14DInCurrency);
            Assert.Null(result.First().PriceChangePercentage30DInCurrency);
            Assert.Null(result.First().PriceChangePercentage200DInCurrency);
            Assert.Null(result.First().PriceChangePercentage1YInCurrency);
        }

        [Fact]
        public async Task TrustScoreNotNull()
        {
            var result = await _client.CoinsClient.GetTickerByCoinId("bitcoin");
            Assert.NotNull(result.Tickers[0].TrustScore);
        }

        [Fact]
        public async Task Qorvo_LastUpdated_Type_Must_Be_DateTimeOffset()
        {
            var result  = await _client.CoinsClient.GetAllCoinDataWithId("qorvo-inc");
            Assert.IsType<DateTimeOffset>(result.MarketData.LastUpdated);
        }
        
        [Fact]
        public async Task Is_Anomaly_Field_Null_Check()
        {
            
            var coinList = new List<string>{"blockplus","bmtoken"};
            
            foreach (var coinId in coinList)
            {
                var result = await _client.CoinsClient.GetAllCoinDataWithId(coinId);
                foreach (var ticker in result.Tickers)
                {
                    Assert.IsType<bool>(ticker.IsAnomaly);
                }
            }
        }
    }
}