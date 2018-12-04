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
            return await GetAsync<CoinMarkets>(QueryStringService.AppendQueryString(CoinsApiEndPoints.CoinList,new Dictionary<string, object>
            {
                {"vs_currency",vsCurrency},
                {"ids",string.Join(",",ids)},
                {"per_page",perPage},
                {"page",page},
                {"sparkline",sparkline}
            }));
        }

        public async Task<CoinByIdFullData> GetAllCoinDataWithId(string id, string localization, bool tickers,
            bool marketData, bool communityData, bool developerData, bool sparkline)
        {
            return await GetAsync<CoinByIdFullData>(QueryStringService.AppendQueryString(
                CoinsApiEndPoints.AllDataWithCoinId(id), new Dictionary<string, object>
                {
                    {"localization", localization},
                    {"tickers", tickers},
                    {"market_data", marketData},
                    {"community_data", communityData},
                    {"developer_data", developerData},
                    {"sparkline", sparkline}
                }));
        }

        public async Task<TickerByCoinId> GetTickerByCoinId(string id, int page)
        {
            return await GetAsync<TickerByCoinId>(QueryStringService.AppendQueryString(
                CoinsApiEndPoints.TickerWithCoinId(id), new Dictionary<string, object>
                {
                    {"page", page}
                }));
        }
    }
    
}