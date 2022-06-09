using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.Global;
using CoinGecko.Interfaces;

using Newtonsoft.Json;

namespace CoinGecko.Clients
{
    public class GlobalClient:BaseApiClient,IGlobalClient
    {
        public GlobalClient(HttpClient httpClient, JsonSerializerSettings serializerSettings, string apiKey = null) : base(httpClient, serializerSettings, apiKey)
        {
        }
        
        public async Task<Global> GetGlobal()
        {
            return await GetAsync<Global>(AppendQueryString(GlobalApiEndPoints.Global)).ConfigureAwait(false);
        }

        public async Task<GlobalDeFi> GetGlobalDeFi()
        {
            return await GetAsync<GlobalDeFi>(AppendQueryString(GlobalApiEndPoints.DecentralizedFinanceDeFi)).ConfigureAwait(false);
        }
    }
}