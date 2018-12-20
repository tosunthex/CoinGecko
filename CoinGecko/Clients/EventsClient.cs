using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.Events;
using CoinGecko.Interfaces;
using CoinGecko.Services;

namespace CoinGecko.Clients
{
    public class EventsClient:BaseApiClient,IEventsClient
    {
        public EventsClient(HttpClient httpClient) : base(httpClient)
        {
        }
        /// <summary>
        /// Get events, paginated by 100
        /// </summary>
        /// <returns></returns>
        public async Task<Events> GetEvents()
        {
            return await GetEvents(new string[] { }, new string[] { }, null, null, null, null);
        }
        
        /// <summary>
        /// Get events, paginated by 100
        /// </summary>
        /// <param name="countryCode">country_code of event (eg. ‘US’)</param>
        /// <param name="type">type of event (eg. ‘Conference’)</param>
        /// <param name="page">page of results (paginated by 100)</param>
        /// <param name="upcommingEventsOnly">lists only upcoming events.(defaults to true, set to false to list all events)</param>
        /// <param name="fromDate">lists events after this date yyyy-mm-dd</param>
        /// <param name="toDate">lists events before this date yyyy-mm-dd (set upcoming_events_only to false if fetching past events)</param>
        /// <returns></returns>
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
        
        /// <summary>
        /// Get list of event countries
        /// </summary>
        /// <returns></returns>
        public async Task<EventCountry> GetEventCountry()
        {
            return await GetAsync<EventCountry>(
                QueryStringService.AppendQueryString(EventsApiEndPoints.EventsCountries));
        }
        
        /// <summary>
        /// Get list of event types
        /// </summary>
        /// <returns></returns>
        public async Task<EventTypes> GetEventTypes()
        {
            return await GetAsync<EventTypes>(QueryStringService.AppendQueryString(EventsApiEndPoints.EventsTypes));
        }
    }
}