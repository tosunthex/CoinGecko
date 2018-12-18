using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.Exchanges;
using CoinGecko.Services;

namespace CoinGecko.Clients
{
    public class ExchangesClient:BaseApiClient
    {
        public ExchangesClient(HttpClient httpClient) : base(httpClient)
        {
        }
        
        /// <summary>
        /// List all exchanges
        /// </summary>
        /// <returns></returns>
        public async Task<Exchanges> GetExchages()
        {
            return await GetAsync<Exchanges>(QueryStringService.AppendQueryString(ExchangesApiEndPointUrl.Exchanges));
        }
        
        /// <summary>
        /// Get exchange volume in BTC and tickers
        /// IMPORTANT:
        /// Ticker is_stale is true when ticker that has not been updated/unchanged from the exchange for a while.
        /// Ticker is_anomaly is true if ticker’s price is outliered by our system.
        /// </summary>
        /// <param name="id">exchange id</param>
        /// <returns></returns>
        public async Task<ExchangeById> GetExchangesByExchangeId(string id)
        {
            return await GetAsync<ExchangeById>(
                QueryStringService.AppendQueryString(ExchangesApiEndPointUrl.ExchangeById(id) ));
        }

        /// <summary>
        /// Get exchange tickers (paginated)
        /// IMPORTANT:
        /// Ticker is_stale is true when ticker that has not been updated/unchanged from the exchange for a while.
        /// Ticker is_anomaly is true if ticker’s price is outliered by our system.
        /// </summary>
        /// <param name="id">exchange id</param>
        /// <returns></returns>
        public Task<TickerByExchangeId> GetTickerByExchangeId(string id)
        {
            return GetTickerByExchangeId(id, null);
        }

        /// <summary>
        /// Get exchange tickers (paginated)
        /// IMPORTANT:
        /// Ticker is_stale is true when ticker that has not been updated/unchanged from the exchange for a while.
        /// Ticker is_anomaly is true if ticker’s price is outliered by our system.
        /// </summary>
        /// <param name="id">exchange id</param>
        /// <param name="page">Page through results</param>
        /// <returns></returns>
        public async Task<TickerByExchangeId> GetTickerByExchangeId(string id,string page)
        {
            return await GetAsync<TickerByExchangeId>(QueryStringService.AppendQueryString(
                ExchangesApiEndPointUrl.TickerById(id), new Dictionary<string, object>
                {
                    {"page",page}
                }));
        }
    }
}