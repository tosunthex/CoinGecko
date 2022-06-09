using CoinGecko.Entities.Response;
using CoinGecko.Interfaces;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoinGecko.Clients
{
    public class PingClient : BaseApiClient, IPingClient
    {
        public PingClient(HttpClient httpClient, JsonSerializerSettings serializerSettings) : base(httpClient, serializerSettings)
        {
        }

        public PingClient(HttpClient httpClient, JsonSerializerSettings serializerSettings, string apiKey) : base(httpClient, serializerSettings, apiKey)
        {
        }

        public async Task<Ping> GetPingAsync()
        {
            return await GetAsync<Ping>(AppendQueryString("ping")).ConfigureAwait(false);
        }
    }
}