using System.Threading.Tasks;
using CoinGecko.Interfaces;
using CoinGecko.Clients;
using Xunit;

namespace CoinGecko.Test
{
    public class SearchClientTests
    {
        private readonly ICoinGeckoClient _client;

        public SearchClientTests()
        {
            _client = CoinGeckoClient.Instance;
        }

        [Fact]
        public async Task SearchTrending_Exchanges_Empty()
        {
            var result = await _client.SearchClient.GetSearchTrending();
            Assert.Empty(result.Exchanges);
        }

        [Fact]
        public async Task SearchTrending_TrendingItems_Fields_Not_Null()
        {
            var result = (await _client.SearchClient.GetSearchTrending()).TrendingItems[0].TrendingItem;
            Assert.NotNull(result.Id);
            Assert.NotNull(result.Name);
            Assert.NotNull(result.Symbol);
            Assert.NotNull(result.Thumb);
            Assert.NotNull(result.Small);
            Assert.NotNull(result.Large);
            Assert.NotNull(result.Slug);
        }
    }
}
