using System.Collections.Generic;
using System.Threading.Tasks;
using CoinGecko.Entities.Response.Finance;

namespace CoinGecko.Interfaces
{
    public interface IFinancePlatformsClient
    {
        Task<IReadOnlyList<FinancePlatforms>> GetFinancePlatforms();
        Task<IReadOnlyList<FinancePlatforms>> GetFinancePlatforms(int perPage, string page);

        Task<IReadOnlyList<FinanceProducts>> GetFinanceProducts();
        Task<IReadOnlyList<FinanceProducts>> GetFinanceProducts(int perPage, string page, string startAt, string endAt);

    }
}