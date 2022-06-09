using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.ExchangeRates;
using CoinGecko.Interfaces;

using Newtonsoft.Json;

namespace CoinGecko.Clients
{
    public class ExchangeRatesClient:BaseApiClient,IExchangeRatesClient
    {
        public ExchangeRatesClient(HttpClient httpClient, JsonSerializerSettings serializerSettings, string apiKey = null) : base(httpClient, serializerSettings, apiKey)
        {
        }

        public async Task<ExchangeRates> GetExchangeRates()
        {
            return await GetAsync<ExchangeRates>(
                AppendQueryString(ExchangeRatesApiEndPoints.ExchangeRate)).ConfigureAwait(false);
        }
    }
}