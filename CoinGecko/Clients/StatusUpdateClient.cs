using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.StatusUpdates;
using CoinGecko.Interfaces;
using CoinGecko.Services;
using Newtonsoft.Json;

namespace CoinGecko.Clients
{
    public class StatusUpdateClient:BaseApiClient,IStatusUpdatesClient
    {
        public StatusUpdateClient(HttpClient httpClient, JsonSerializerSettings serializerSettings) : base(httpClient, serializerSettings)
        {
        }

        public async Task<StatusUpdate> GetStatusUpdate()
        {
            return await GetStatusUpdate("", "", null, null).ConfigureAwait(false);
        }

        public async Task<StatusUpdate> GetStatusUpdate(string category, string projectType, int? perPage, int? page)
        {
            return await GetAsync<StatusUpdate>(QueryStringService.AppendQueryString(
                StatusUpdateApiEndPoints.StatusUpdateUrl, new Dictionary<string, object>
                {
                    {"category",category},
                    {"project_type",projectType},
                    {"per_page",perPage},
                    {"page",page}
                })).ConfigureAwait(false);
        }
    }
}