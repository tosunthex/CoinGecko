using System.Collections.Generic;
using System.Threading.Tasks;
using CoinGecko.Entities.Response.Finance;

namespace CoinGecko.Interfaces
{
    public interface IFinancePlatformsClient
    {
        /// <summary>
        /// List all finance platforms
        /// </summary>
        /// <returns></returns>
        Task<IReadOnlyList<FinancePlatforms>> GetFinancePlatforms();

        /// <summary>
        /// List all finance platforms
        /// </summary>
        /// <param name="perPage">Total results per page</param>
        /// <param name="page">page of results (paginated to 100 by default)</param>
        /// <returns></returns>
        Task<IReadOnlyList<FinancePlatforms>> GetFinancePlatforms(int perPage, string page);

        /// <summary>
        /// List all finance products
        /// </summary>
        /// <returns></returns>
        Task<IReadOnlyList<FinanceProducts>> GetFinanceProducts();

        /// <summary>
        /// List all finance products
        /// </summary>
        /// <param name="perPage">Total results per page</param>
        /// <param name="page">page of results (paginated to 100 by default)</param>
        /// <param name="startAt">start date of the financial products</param>
        /// <param name="endAt">end date of the financial products</param>
        /// <returns></returns>
        Task<IReadOnlyList<FinanceProducts>> GetFinanceProducts(int perPage, string page, string startAt, string endAt);

    }
}