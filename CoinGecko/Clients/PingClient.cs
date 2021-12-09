using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.Entities.Response;
using CoinGecko.Interfaces;
using CoinGecko.Services;
using Newtonsoft.Json;

namespace CoinGecko.Clients
{
    public class PingClient:BaseApiClient,IPingClient
    {
        public PingClient(HttpClient httpClient, JsonSerializerSettings serializerSettings) : base(httpClient, serializerSettings)
        {
        }
        
        public async Task<Ping> GetPingAsync()
        {
            return await GetAsync<Ping>(QueryStringService.AppendQueryString("ping")).ConfigureAwait(false);
        }

        
    }
}