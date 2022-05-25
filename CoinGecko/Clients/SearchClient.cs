using CoinGecko.Entities.Response.Search;
using System.Collections.Generic;
using CoinGecko.ApiEndPoints;
using System.Threading.Tasks;
using CoinGecko.Interfaces;
using CoinGecko.Services;
using System.Net.Http;
using Newtonsoft.Json;

namespace CoinGecko.Clients
{
    public class SearchClient : BaseApiClient, ISearchClient
    {
        public SearchClient(HttpClient httpClient, JsonSerializerSettings jsonSerializerSetting) : base(httpClient, jsonSerializerSetting)
        {
        }

        public async Task<TrendingList> GetSearchTrending()
        {
            return await GetAsync<TrendingList>(
                QueryStringService.AppendQueryString(SearchApiEndpoints.SearchTrending))
                .ConfigureAwait(false);
        }
    }
}
