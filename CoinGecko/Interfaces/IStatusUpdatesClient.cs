using System.Threading.Tasks;
using CoinGecko.Entities.Response.StatusUpdates;

namespace CoinGecko.Interfaces
{
    public interface IStatusUpdatesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<StatusUpdate> GetStatusUpdate();

        /// <summary>
        /// List all status_updates with data (description, category, created_at, user, user_title and pin)
        /// </summary>
        /// <param name="category">Filtered by category (eg. general, milestone, partnership, exchange_listing, software_release, fund_movement, new_listings, event)</param>
        /// <param name="projectType">Filtered by Project Type (eg. coin, market). If left empty returns both status from coins and markets</param>
        /// <param name="perPage">Total results per page</param>
        /// <param name="page">Page through results</param>
        /// <returns></returns>
        Task<StatusUpdate> GetStatusUpdate(string category, string projectType, int? perPage, int? page);
    }
}