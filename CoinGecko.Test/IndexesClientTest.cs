using System.Threading.Tasks;
using CoinGecko.Clients;
using CoinGecko.Interfaces;
using Xunit;

namespace CoinGecko.Test
{
    public class IndexesClientTest
    {
        private readonly ICoinGeckoClient _client;
        public IndexesClientTest()
        {
            _client = CoinGeckoClient.Instance;
        }

        [Fact]
        public async Task Indexes_Count_Not_Equal_Zero()
        {
            var result = await _client.IndexesClient.GetIndexes();
            Assert.True(result.Count > 0, "Result GTE 0");
        }

        [Fact]
        public async Task Indexes_By_ID_For_BTC_Return_Deribit_BTC()
        {
            var result = await _client.IndexesClient.GetIndexById("BTC");
            Assert.Equal("Deribit BTC", result.Name);
        }

        [Fact]
        public async Task Indexes_List_Count_Not_Equal_Zero()
        {
            var result = await _client.IndexesClient.GetIndexList();
            Assert.True( result.Count > 0,"Result GTE 0");
        }
    }
}