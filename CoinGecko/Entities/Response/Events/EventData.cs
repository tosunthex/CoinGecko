using System;
using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Events
{
    public class EventData
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("organizer")]
        public string Organizer { get; set; }

        [JsonProperty("start_date")]
        public DateTimeOffset? StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTimeOffset? EndDate { get; set; }

        [JsonProperty("website")]
        public Uri Website { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("venue")]
        public string Venue { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("screenshot")]
        public Uri Screenshot { get; set; }
    }
}