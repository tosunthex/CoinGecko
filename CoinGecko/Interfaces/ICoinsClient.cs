using System.Collections.Generic;
using System.Threading.Tasks;
using CoinGecko.Entities.Response.Coins;

namespace CoinGecko.Interfaces
{
    public interface ICoinsClient
    {
        /// <summary>
        /// List all coins with data (name, price, market, developer, community, etc) - paginated by 50
        /// </summary>
        /// <returns></returns>
        Task<IReadOnlyList<CoinFullData>> GetAllCoinsData();

        /// <summary>
        /// List all coins with data (name, price, market, developer, community, etc) - paginated by 50
        /// </summary>
        /// <param name="order">order by</param>
        /// <param name="perPage">Total results per page</param>
        /// <param name="page">Page through results</param>
        /// <param name="localization">Set to false to exclude localized languages in response</param>
        /// <param name="sparkline">Include sparkline 7 days data (true/false) [default: false]</param>
        /// <returns></returns>
        Task<IReadOnlyList<CoinFullData>> GetAllCoinsData(string order, int? perPage, int? page, string localization,
            bool? sparkline);

        /// <summary>
        /// List all supported coins id, name and symbol
        /// </summary>
        /// <returns></returns>
        Task<IReadOnlyList<CoinList>> GetCoinList();

        /// <summary>
        /// List all supported coins price, market cap, volume, and market related data (no pagination required)
        /// </summary>
        /// <param name="vsCurrency">The target currency of market data</param>
        /// <returns></returns>
        Task<List<CoinMarkets>> GetCoinMarkets(string vsCurrency);

        /// <summary>
        /// List all supported coins price, market cap, volume, and market related data (no pagination required)
        /// </summary>
        /// <param name="vsCurrency">The target currency of market data</param>
        /// <param name="ids">List of coin id to filter if you want specific results in comma-separated</param>
        /// <param name="order">Results ordered by</param>
        /// <param name="perPage">Total results per page</param>
        /// <param name="page">Page through results</param>
        /// <param name="sparkline">Include sparkline 7 days data default false</param>
        /// <param name="priceChangePercentage">Include price change percentage in 1h, 24h, 7d, 14d, 30d, 200d, 1y (eg. '1h,24h,7d' comma-separated, invalid values will be discarded)</param>
        /// <returns></returns>
        Task<List<CoinMarkets>> GetCoinMarkets(string vsCurrency, string[] ids, string order, int? perPage, int? page,
            bool sparkline, string priceChangePercentage);

        /// <summary>
        /// Get current data (name, price, market, … including exchange tickers) for a coin.
        /// </summary>
        /// <param name="id">coin id</param>
        /// <returns></returns>
        Task<CoinFullDataById> GetAllCoinDataWithId(string id);

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
        Task<CoinFullDataById> GetAllCoinDataWithId(string id, string localization, bool tickers,
            bool marketData, bool communityData, bool developerData, bool sparkline);

        /// <summary>
        /// Get coin tickers (paginated to 100 items)
        /// </summary>
        /// <param name="id">coin id</param>
        /// <param name="page">Page through results</param>
        /// <returns></returns>
        Task<TickerById> GetTickerByCoinId(string id);

        /// <summary>
        /// Get coin tickers (paginated to 100 items)
        /// </summary>
        /// <param name="id">coin id</param>
        /// <param name="page">Page through results</param>
        /// <returns></returns>
        Task<TickerById> GetTickerByCoinId(string id, int? page);

        /// <summary>
        /// Get coin tickers (paginated to 100 items)
        /// </summary>
        /// <param name="id">coin id</param>
        /// <param name="exchanges">Exchange ids</param>
        /// <param name="page">Page through results</param>
        /// <returns></returns>
        Task<TickerById> GetTickerByCoinId(string id, string[] exchanges, int? page);

        /// <summary>
        /// Get historical data (name, price, market, stats) at a given date for a coin
        /// </summary>
        /// <param name="id">coin id</param>
        /// <param name="date">The date of data snapshot in dd-mm-yyyy eg. 30-12-2017</param>
        /// <param name="localization">Set to false to exclude localized languages in response</param>
        /// <returns></returns>
        Task<CoinFullData> GetHistoryByCoinId(string id, string date, string localization);

        /// <summary>
        /// Get historical market data include price, market cap, and 24h volume (granularity auto)
        /// </summary>
        /// <param name="id">coin id</param>
        /// <param name="vsCurrency">The target currency of market data (usd, eur, jpy, etc.)</param>
        /// <param name="days">Data up to number of days ago (eg. 1,14,30,max)</param>
        /// <returns></returns>
        Task<MarketChartById> GetMarketChartsByCoinId(string id, string[] vsCurrency, string days);
    }
}