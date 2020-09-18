using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.Global;
using CoinGecko.Interfaces;
using CoinGecko.Services;

namespace CoinGecko.Clients
{
    public class GlobalClient:BaseApiClient,IGlobalClient
    {
        public GlobalClient(HttpClient httpClient) : base(httpClient)
        {
        }
        
        public async Task<Global> GetGlobal()
        {
            return await GetAsync<Global>(QueryStringService.AppendQueryString(GlobalApiEndPoints.Global)).ConfigureAwait(false);
        }

        public async Task<Global> GetGlobalDeFi()
        {
            return await GetAsync<Global>(QueryStringService.AppendQueryString(GlobalApiEndPoints.DecentralizedFinanceDeFi)).ConfigureAwait(false);
        }
    }
}