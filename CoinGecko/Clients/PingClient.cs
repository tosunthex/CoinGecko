using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.Entities.Response;
using CoinGecko.Services;

namespace CoinGecko.Clients
{
    public class PingClient:BaseApiClient
    {
        public PingClient(HttpClient httpClient) : base(httpClient)
        {
        }
        
        /// <summary>
        /// Check API server status
        /// </summary>
        /// <returns></returns>
        public async Task<Ping> GetPingAsync()
        {
            return await GetAsync<Ping>(QueryStringService.AppendQueryString("ping"));
        }

        
    }
}