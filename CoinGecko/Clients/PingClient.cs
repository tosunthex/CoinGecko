using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.Entities.Response;
using CoinGecko.Interfaces;
using CoinGecko.Services;

namespace CoinGecko.Clients
{
    public class PingClient:BaseApiClient,IPingClient
    {
        public PingClient(HttpClient httpClient) : base(httpClient)
        {
        }
        
        public async Task<Ping> GetPingAsync()
        {
            return await GetAsync<Ping>(QueryStringService.AppendQueryString("ping"));
        }

        
    }
}