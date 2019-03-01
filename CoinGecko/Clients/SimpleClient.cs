using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.Simple;
using CoinGecko.Interfaces;
using CoinGecko.Services;

namespace CoinGecko.Clients
{
    public class SimpleClient:BaseApiClient,ISimpleClient
    {
        
        public SimpleClient(HttpClient httpClient) : base(httpClient)
        {
        }
        
        public async Task<Price> GetSimplePrice(string[] ids, string[] vsCurrencies)
        {
            return await GetSimplePrice(ids, vsCurrencies, false, false);
        }
        public async Task<Price> GetSimplePrice(string[] ids, string[] vsCurrencies, bool include24HVol,
            bool includeLastUpdatedAt)
        {
            
            return await GetAsync<Price>(QueryStringService.AppendQueryString(SimpleApiEndPoints.SimplePrice,
                new Dictionary<string, object>
                {
                    {"ids", string.Join(",",ids)},
                    {"vs_currencies",string.Join(",",vsCurrencies)},
                    {"include_24hr_vol",include24HVol},
                    {"include_last_updated_at",includeLastUpdatedAt}
                })).ConfigureAwait(false);
        }
        
        public async Task<SupportedCurrencies> GetSupportedVsCurrencies()
        {
            return await GetAsync<SupportedCurrencies>(
                QueryStringService.AppendQueryString(SimpleApiEndPoints.SimpleSupportedVsCurrencies)).ConfigureAwait(false);
        }
    }
}