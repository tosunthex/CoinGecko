using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.ExchangeRates;
using CoinGecko.Services;

namespace CoinGecko.Clients
{
    public class ExchangeRatesClient:BaseApiClient
    {
        public ExchangeRatesClient(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <summary>
        /// Get BTC-to-Currency exchange rates
        /// </summary>
        /// <returns></returns>
        public async Task<ExchangeRates> GetExchangeRates()
        {
            return await GetAsync<ExchangeRates>(
                QueryStringService.AppendQueryString(ExchangeRatesApiEndPoints.ExchangeRate));
        }
    }
}