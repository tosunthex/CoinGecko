using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.Simple;
using CoinGecko.Interfaces;
using CoinGecko.Services;
using Newtonsoft.Json;

namespace CoinGecko.Clients
{
    public class SimpleClient:BaseApiClient,ISimpleClient
    {
        
        public SimpleClient(HttpClient httpClient, JsonSerializerSettings serializerSettings) : base(httpClient, serializerSettings)
        {
        }
        
        public async Task<Price> GetSimplePrice(string[] ids, string[] vsCurrencies)
        {
            return await GetSimplePrice(ids, vsCurrencies,false, false, false, false).ConfigureAwait(false);
        }
        public async Task<Price> GetSimplePrice(string[] ids, string[] vsCurrencies,bool includeMarketCap,
            bool include24HVol,bool include24HChange,bool includeLastUpdatedAt)
        {
            return await GetAsync<Price>(QueryStringService.AppendQueryString(SimpleApiEndPoints.SimplePrice,
                new Dictionary<string, object>
                {
                    {"ids", string.Join(",",ids)},
                    {"vs_currencies",string.Join(",",vsCurrencies)},
                    {"include_market_cap",includeMarketCap},
                    {"include_24hr_vol",include24HVol},
                    {"include_24hr_change",include24HChange},
                    {"include_last_updated_at",includeLastUpdatedAt}
                })).ConfigureAwait(false);
        }

        public async Task<TokenPrice> GetTokenPrice(string id, string[] contractAddress, string[] vsCurrencies)
        {
            return await GetTokenPrice(id, contractAddress, vsCurrencies, false, false, false, false).ConfigureAwait(false);
        }

        public async Task<TokenPrice> GetTokenPrice(string id, string[] contractAddress, string[] vsCurrencies, bool includeMarketCap,
            bool include24HVol, bool include24HChange, bool includeLastUpdatedAt)
        {
            return await GetAsync<TokenPrice>(QueryStringService.AppendQueryString(SimpleApiEndPoints.TokenPrice(id),
                new Dictionary<string, object>
                {
                    {"contract_addresses",string.Join(",",contractAddress)},
                    {"vs_currencies",string.Join(",",vsCurrencies)},
                    {"include_market_cap",includeMarketCap},
                    {"include_24hr_vol",include24HVol},
                    {"include_24hr_change",include24HChange},
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