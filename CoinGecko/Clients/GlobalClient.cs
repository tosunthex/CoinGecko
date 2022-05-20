using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.Global;
using CoinGecko.Interfaces;
using CoinGecko.Services;
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
            return await GetAsync<Global>(QueryStringService.AppendQueryString(GlobalApiEndPoints.Global)).ConfigureAwait(false);
        }

        public async Task<GlobalDeFi> GetGlobalDeFi()
        {
            return await GetAsync<GlobalDeFi>(QueryStringService.AppendQueryString(GlobalApiEndPoints.DecentralizedFinanceDeFi)).ConfigureAwait(false);
        }
    }
}