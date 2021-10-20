using System.Collections.Generic;
using System.Threading.Tasks;
using CoinGecko.Entities.Response.Exchanges;

namespace CoinGecko.Interfaces
{
    public interface IExchangesClient
    {
        /// <summary>
        /// List all exchanges
        /// </summary>
        /// <returns></returns>
        Task<IReadOnlyList<Exchanges>> GetExchanges();

        /// <summary>
        /// List all exchanges
        /// </summary>
        /// <param name="perPage">Total results per page</param>
        /// <param name="page">page through results</param>
        /// <returns></returns>
        Task<IReadOnlyList<Exchanges>> GetExchanges(int perPage,string page);

        /// <summary>
        /// List all supported markets id and name(no pagination required)
        /// </summary>
        /// <returns></returns>
        Task<IReadOnlyList<ExchangesList>> GetExchangesList();

        /// <summary>
        /// Get exchange volume in BTC and tickers
        /// IMPORTANT:
        /// Ticker is_stale is true when ticker that has not been updated/unchanged from the exchange for a while.
        /// Ticker is_anomaly is true if ticker’s price is outliered by our system.
        /// </summary>
        /// <param name="id">exchange id</param>
        /// <returns></returns>
        Task<ExchangeById> GetExchangesByExchangeId(string id);

        /// <summary>
        /// Get exchange tickers (paginated)
        /// IMPORTANT:
        /// Ticker is_stale is true when ticker that has not been updated/unchanged from the exchange for a while.
        /// Ticker is_anomaly is true if ticker’s price is outliered by our system.
        /// </summary>
        /// <param name="id">exchange id</param>
        /// <returns></returns>
        Task<TickerByExchangeId> GetTickerByExchangeId(string id);

        /// <summary>
        /// Get exchange tickers (paginated)
        /// IMPORTANT:
        /// Ticker is_stale is true when ticker that has not been updated/unchanged from the exchange for a while.
        /// Ticker is_anomaly is true if ticker’s price is outliered by our system.
        /// </summary>
        /// <param name="id">exchange id</param>
        /// <param name="page">Page through results</param>
        /// <returns></returns>
        Task<TickerByExchangeId> GetTickerByExchangeId(string id, string page);

        /// <summary>
        /// Get exchange tickers (paginated)
        /// IMPORTANT:
        /// Ticker is_stale is true when ticker that has not been updated/unchanged from the exchange for a while.
        /// Ticker is_anomaly is true if ticker’s price is outliered by our system.
        /// </summary>
        /// <param name="id">exchange id</param>
        /// <param name="coinIds">filter tickers by coin_ids</param>
        /// <param name="page">Page through results</param>
        /// <param name="includeExchangeLogo"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        Task<TickerByExchangeId> GetTickerByExchangeId(string id, string[] coinIds, string page, string includeExchangeLogo, string order);


        /// <summary>
        /// Get status updates for a given exchange
        /// </summary>
        /// <param name="id">pass the exchange id (can be obtained from /exchanges/list) eg. binance</param>
        /// <returns></returns>
        //Task<TickerByExchangeId> GetStatusUpdateByExchangeId(string id);

        /// <summary>
        /// Get status updates for a given exchange
        /// </summary>
        /// <param name="id">pass the exchange id (can be obtained from /exchanges/list) eg. binance</param>
        /// <param name="perPage">Total results per page</param>
        /// <param name="page">Page through results</param>
        /// <returns></returns>
        //Task<TickerByExchangeId> GetStatusUpdateByExchangeId(string id, int perPage, string page);

        Task<IReadOnlyList<VolumeChart>> GetVolumeChartsByExchangeId(string id, int days);


    }
}