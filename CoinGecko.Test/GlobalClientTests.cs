using CoinGecko.Clients;
using Xunit;

namespace CoinGecko.Test
{
    public class GlobalClientTests
    {
        private readonly CoinGeckoClient _client;

        public GlobalClientTests()
        {
            _client = CoinGeckoClient.Instance;
        }

        [Fact]
        public async void Global_Data_Must_Not_Null()
        {
            var result = await _client.GlobalClient.GetGlobal();
            Assert.NotNull(result.Data);
        }
    }
}