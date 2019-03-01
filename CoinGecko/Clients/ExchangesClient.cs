using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.Exchanges;
using CoinGecko.Interfaces;
using CoinGecko.Services;

namespace CoinGecko.Clients
{
    public class ExchangesClient:BaseApiClient,IExchangesClient
    {
        public ExchangesClient(HttpClient httpClient) : base(httpClient)
        {
        }
        
        public async Task<IReadOnlyList<Exchanges>> GetExchanges()
        {
            return await GetAsync<IReadOnlyList<Exchanges>>(
                QueryStringService.AppendQueryString(ExchangesApiEndPoints.Exchanges));
        }

        public async Task<IReadOnlyList<ExchangesList>> GetExchangesList()
        {
            return await GetAsync<IReadOnlyList<ExchangesList>>(
                QueryStringService.AppendQueryString(ExchangesApiEndPoints.ExchangesList));
        }

        public async Task<ExchangeById> GetExchangesByExchangeId(string id)
        {
            return await GetAsync<ExchangeById>(
                QueryStringService.AppendQueryString(ExchangesApiEndPoints.ExchangeById(id) ));
        }

        public async Task<TickerByExchangeId> GetTickerByExchangeId(string id)
        {
            return await GetTickerByExchangeId(id, null);
        }

        public async Task<TickerByExchangeId> GetTickerByExchangeId(string id,string page)
        {
            return await GetAsync<TickerByExchangeId>(QueryStringService.AppendQueryString(
                ExchangesApiEndPoints.TickerById(id), new Dictionary<string, object>
                {
                    {"page",page}
                }));
        }
    }
}