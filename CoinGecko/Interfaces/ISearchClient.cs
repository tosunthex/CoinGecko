using System.Threading.Tasks;
using System.Collections.Generic;
using CoinGecko.Entities.Response.Search;

namespace CoinGecko.Interfaces
{
    public interface ISearchClient
    {
        /// <summary>
        /// Get trending search coins (Top-7) on CoinGecko in the last 24 hours
        /// </summary>
        /// <returns></returns>
        Task<TrendingList> GetSearchTrending();
    }
}
