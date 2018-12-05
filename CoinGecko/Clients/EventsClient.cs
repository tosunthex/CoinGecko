using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.Events;
using CoinGecko.Services;

namespace CoinGecko.Clients
{
    public class EventsClient:BaseApiClient
    {
        public EventsClient(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<Events> GetEvents(string[] countryCode, string[] type, string page, string upcommingEventsOnly,
            string fromDate, string toDate)
        {
            return await GetAsync<Events>(QueryStringService.AppendQueryString(EventsApiEndPoints.Events,
                new Dictionary<string, object>
                {
                    {"country_code",string.Join(",",countryCode)},
                    {"type",string.Join(",",type)},
                    {"page",page},
                    {"upcoming_events_only",upcommingEventsOnly},
                    {"from_date",fromDate},
                    {"to_date",toDate}
                }));
        }
    }
}