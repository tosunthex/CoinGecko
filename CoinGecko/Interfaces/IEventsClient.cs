using System.Threading.Tasks;
using CoinGecko.Entities.Response.Events;

namespace CoinGecko.Interfaces
{
    public interface IEventsClient
    {
        /// <summary>
        /// Get events, paginated by 100
        /// </summary>
        /// <returns></returns>
        Task<Events> GetEvents();

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
        Task<Events> GetEvents(string[] countryCode, string[] type, string page,
            string upcommingEventsOnly,
            string fromDate, string toDate);

        /// <summary>
        /// Get list of event countries
        /// </summary>
        /// <returns></returns>
        Task<EventCountry> GetEventCountry();

        /// <summary>
        /// Get list of event types
        /// </summary>
        /// <returns></returns>
        Task<EventTypes> GetEventTypes();
    }
}