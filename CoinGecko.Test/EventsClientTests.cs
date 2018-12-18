using System.Threading;
using System.Threading.Tasks;
using CoinGecko.Clients;
using Xunit;

namespace CoinGecko.Test
{
    public class EventsClientTests
    {
        private readonly CoinGeckoClient _client;

        public EventsClientTests()
        {
            _client = CoinGeckoClient.Instance;
        }

        [Fact]
        public async Task Events_Count_Equal_to_Data_Length()
        {
            var result = await _client.EventsClient.GetEvents();
            Assert.Equal(result.Count,result.Data.Length);
        }

        [Fact]
        public async Task Events_Country_Count_Equal_to_Data_Length()
        {
            var result = await _client.EventsClient.GetEventCountry();
            Assert.Equal(result.Count,result.Data.Length);
        }
        [Fact]
        public async Task Events_Types_Count_Equal_to_Data_Length()
        {
            var result = await _client.EventsClient.GetEventTypes();
            Assert.Equal(result.Count,result.Data.Length);
        }
    }
}