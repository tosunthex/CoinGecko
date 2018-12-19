using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.Global;
using CoinGecko.Services;

namespace CoinGecko.Clients
{
    public class GlobalClient:BaseApiClient
    {
        public GlobalClient(HttpClient httpClient) : base(httpClient)
        {
        }
        
        /// <summary>
        /// Get cryptocurrency global data
        /// </summary>
        /// <returns></returns>
        public async Task<Global> GetGlobal()
        {
            return await GetAsync<Global>(QueryStringService.AppendQueryString(GlobalApiEndPoints.Global));
        }
    }
}