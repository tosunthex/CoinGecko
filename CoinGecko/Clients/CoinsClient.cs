using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.Coins;
using CoinGecko.Parameters;
using CoinGecko.Services;

namespace CoinGecko.Clients
{
    public class CoinsClient:BaseApiClient
    {
        public CoinsClient(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <summary>
        /// List all coins with data (name, price, market, developer, community, etc) - paginated by 50
        /// </summary>
        /// <param name="order">order by</param>
        /// <param name="perPage">Total results per page</param>
        /// <param name="page">Page through results</param>
        /// <param name="localization">Set to false to exclude localized languages in response</param>
        /// <param name="sparkline">Include sparkline 7 days data (true/false) [default: false]</param>
        /// <returns></returns>
        public Task<IReadOnlyList<CoinFullData>> GetAllCoinsData()
        {
            return GetAllCoinsData(OrderField.GeckoDesc, 1, 1, "false", false);
        }

        /// <summary>
        /// List all coins with data (name, price, market, developer, community, etc) - paginated by 50
        /// </summary>
        /// <param name="order">order by</param>
        /// <param name="perPage">Total results per page</param>
        /// <param name="page">Page through results</param>
        /// <param name="localization">Set to false to exclude localized languages in response</param>
        /// <param name="sparkline">Include sparkline 7 days data (true/false) [default: false]</param>
        /// <returns></returns>
        public async Task<IReadOnlyList<CoinFullData>> GetAllCoinsData(string order,int? perPage,int? page,string localization,bool sparkline)
        {
            return await GetAsync<IReadOnlyList<CoinFullData>>(QueryStringService.AppendQueryString(
                CoinsApiEndPoints.Coins, new Dictionary<string, object>
                {
                    {"order", order},
                    {"per_page", perPage},
                    {"page",page},
                    {"localization",localization},
                    {"sparkline",sparkline}
                }));
        }

        /// <summary>
        /// List all supported coins id, name and symbol
        /// </summary>
        /// <returns></returns>
        public async Task<CoinList> GetCoinList()
        {
            return await GetAsync<CoinList>(QueryStringService.AppendQueryString(CoinsApiEndPoints.CoinList));
        }

        /// <summary>
        /// List all supported coins price, market cap, volume, and market related data (no pagination required)
        /// </summary>
        /// <param name="vsCurrency">The target currency of market data</param>
        /// <returns></returns>
        public Task<CoinMarkets> GetCoinMarkets(string vsCurrency)
        {
            return GetCoinMarkets(vsCurrency, new string[] { }, null, null, null, false);
        }

        /// <summary>
        /// List all supported coins price, market cap, volume, and market related data (no pagination required)
        /// </summary>
        /// <param name="vsCurrency">The target currency of market data</param>
        /// <param name="ids">List of coin id to filter if you want specific results in comma-separated</param>
        /// <param name="order">Results ordered by</param>
        /// <param name="perPage">Total results per page</param>
        /// <param name="page">Page through results</param>
        /// <param name="sparkline">Include sparkline 7 days data default false</param>
        /// <returns></returns>
        public async Task<CoinMarkets> GetCoinMarkets(string vsCurrency,string[] ids,string order,int? perPage,int? page,bool sparkline)
        {
            return await GetAsync<CoinMarkets>(QueryStringService.AppendQueryString(CoinsApiEndPoints.CoinMarkets,new Dictionary<string, object>
            {
                {"vs_currency",vsCurrency},
                {"ids",string.Join(",",ids)},
                {"per_page",perPage},
                {"page",page},
                {"sparkline",sparkline}
            }));
        }
        
        /// <summary>
        /// Get current data (name, price, market, … including exchange tickers) for a coin.
        /// </summary>
        /// <param name="id">coin id</param>
        /// <param name="localization">Include all localized languages in response (true/false) [default: true]</param>
        /// <param name="tickers">Include tickers data (true/false) [default: true]</param>
        /// <param name="marketData">Include market_data (true/false) [default: true]</param>
        /// <param name="communityData">Include community_data data (true/false) [default: true]</param>
        /// <param name="developerData">Include developer_data data (true/false) [default: true]</param>
        /// <param name="sparkline">Include sparkline 7 days data (eg. true, false) [default: false]</param>
        /// <returns></returns>
        public async Task<CoinFullDataById> GetAllCoinDataWithId(string id, string localization, bool tickers,
            bool marketData, bool communityData, bool developerData, bool sparkline)
        {
            return await GetAsync<CoinFullDataById>(QueryStringService.AppendQueryString(
                CoinsApiEndPoints.AllDataByCoinId(id), new Dictionary<string, object>
                {
                    {"localization", localization},
                    {"tickers", tickers},
                    {"market_data", marketData},
                    {"community_data", communityData},
                    {"developer_data", developerData},
                    {"sparkline", sparkline}
                }));
        }
        
        /// <summary>
        /// Get coin tickers (paginated to 100 items)
        /// </summary>
        /// <param name="id">coin id</param>
        /// <param name="page">Page through results</param>
        /// <returns></returns>
        public async Task<TickerById> GetTickerByCoinId(string id, int page)
        {
            return await GetAsync<TickerById>(QueryStringService.AppendQueryString(
                CoinsApiEndPoints.TickerByCoinId(id), new Dictionary<string, object>
                {
                    {"page", page}
                }));
        }

        /// <summary>
        /// Get historical data (name, price, market, stats) at a given date for a coin
        /// </summary>
        /// <param name="id">coin id</param>
        /// <param name="date">The date of data snapshot in dd-mm-yyyy eg. 30-12-2017</param>
        /// <param name="localization">Set to false to exclude localized languages in response</param>
        /// <returns></returns>
        public async Task<CoinFullData> GetHistoryByCoinId(string id, string date, string localization)
        {
            return await GetAsync<CoinFullData>(QueryStringService.AppendQueryString(
                CoinsApiEndPoints.HistoryByCoinId(id), new Dictionary<string, object>
                {
                    {"date",date},
                    {"localization",localization}
                }));
        }

        /// <summary>
        /// Get historical market data include price, market cap, and 24h volume (granularity auto)
        /// </summary>
        /// <param name="id">coin id</param>
        /// <param name="vsCurrency">The target currency of market data (usd, eur, jpy, etc.)</param>
        /// <param name="days">Data up to number of days ago (eg. 1,14,30,max)</param>
        /// <returns></returns>
        public async Task<MarketChartById> GetMarketChartsByCoinId(string id, string[] vsCurrency, string days)
        {
            return await GetAsync<MarketChartById>(QueryStringService.AppendQueryString(
                CoinsApiEndPoints.MarketChartByCoinId(id), new Dictionary<string, object>
                {
                    {"vs_currency", string.Join(",",vsCurrency)},
                    {"days", days}
                }));
        }
        
        
    }
    
}