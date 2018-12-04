using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response;
using CoinGecko.Entities.Response.Simple;
using CoinGecko.Parameters;
using CoinGecko.Services;

namespace CoinGecko.Clients
{
    public class SimpleClient:BaseApiClient
    {
        
        public SimpleClient(HttpClient httpClient) : base(httpClient)
        {
        }
        /// <summary>
        /// Get the current price of any cryptocurrencies in any other supported currencies that you need.
        /// </summary>
        /// <param name="ids">id of coins, comma-separated if querying more than 1 coin refers to coins/list</param>
        /// <param name="vsCurrencies">vs_currency of coins, comma-separated if querying more than 1 vs_currency
        /// *refers to simple/supported_vs_currencies</param>
        /// <returns></returns>
        public Task<Price> GetSimplePrice(string[] ids, string[] vsCurrencies)
        {
            return GetSimplePrice(ids, vsCurrencies, false, false);
        }
        
        /// <summary>
        /// Get the current price of any cryptocurrencies in any other supported currencies that you need.
        /// </summary>
        /// <param name="ids">id of coins, comma-separated if querying more than 1 coin refers to coins/list</param>
        /// <param name="vsCurrencies">vs_currency of coins, comma-separated if querying more than 1 vs_currency
        /// *refers to simple/supported_vs_currencies</param>
        /// <param name="include24HVol">to include 24hr_vol</param>
        /// <param name="includeLastUpdatedAt">to include last_updated_at of price</param>
        /// <returns></returns>
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
                }));
        }

        /// <summary>
        /// Get list of Supported vs currencies.
        /// </summary>
        /// <returns></returns>
        public async Task<SupportedCurrencies> GetSupportedVsCurrencies()
        {
            return await GetAsync<SupportedCurrencies>(
                QueryStringService.AppendQueryString(SimpleApiEndPoints.SimpleSupportedVsCurrencies));
        }
    }
}