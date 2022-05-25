using System.Threading.Tasks;
using System.Collections.Generic;
using CoinGecko.Entities.Response.Search;

namespace CoinGecko.Interfaces
{
    public interface ISearchClient
    {
        /// <summary>
        /// Top-7 trending coins on CoinGecko as searched by users in the last 24 hours (Ordered by most popular first)
        /// </summary>
        /// <returns></returns>
        Task<TrendingList> GetSearchTrending();
    }
}
