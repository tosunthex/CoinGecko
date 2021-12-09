using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.Indexes;
using CoinGecko.Interfaces;
using CoinGecko.Services;
using Newtonsoft.Json;

namespace CoinGecko.Clients
{
    public class IndexesClient:BaseApiClient,IIndexesClient
    {
        public IndexesClient(HttpClient httpClient, JsonSerializerSettings serializerSettings) : base(httpClient, serializerSettings)
        {
        }

        public async Task<IReadOnlyList<IndexData>> GetIndexes()
        {
            return await GetIndexes(null, "").ConfigureAwait(false);
        }

        public async Task<IReadOnlyList<IndexData>> GetIndexes(int? perPage, string page)
        {
            return await GetAsync<IReadOnlyList<IndexData>>(QueryStringService.AppendQueryString(
                IndexesApiEndPointUrl.IndexesUrl, new Dictionary<string, object>
                {
                    {"per_page",perPage},
                    {"page",page}
                })).ConfigureAwait(false);
        }

        public async Task<IndexData> GetIndexById(string id)
        {
            return await GetAsync<IndexData>(QueryStringService.AppendQueryString(
                IndexesApiEndPointUrl.IndexesWithId(id))).ConfigureAwait(false);
        }

        public async Task<IReadOnlyList<IndexList>> GetIndexList()
        {
            return await GetAsync<IReadOnlyList<IndexList>>(QueryStringService.AppendQueryString(
                IndexesApiEndPointUrl.IndexesList)).ConfigureAwait(false);
        }
    }
}