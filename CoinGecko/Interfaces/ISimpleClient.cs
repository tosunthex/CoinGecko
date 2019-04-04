using System.Threading.Tasks;
using CoinGecko.Entities.Response.Simple;

namespace CoinGecko.Interfaces
{
    public interface ISimpleClient
    {
        /// <summary>
        /// Get the current price of any cryptocurrencies in any other supported currencies that you need.
        /// </summary>
        /// <param name="ids">id of coins, comma-separated if querying more than 1 coin refers to coins/list</param>
        /// <param name="vsCurrencies">vs_currency of coins, comma-separated if querying more than 1 vs_currency
        /// *refers to simple/supported_vs_currencies</param>
        /// <returns></returns>
        Task<Price> GetSimplePrice(string[] ids, string[] vsCurrencies);

        /// <summary>
        /// Get the current price of any cryptocurrencies in any other supported currencies that you need.
        /// </summary>
        /// <param name="ids">id of coins, comma-separated if querying more than 1 coin refers to coins/list</param>
        /// <param name="vsCurrencies">vs_currency of coins, comma-separated if querying more than 1 vs_currency
        /// *refers to simple/supported_vs_currencies</param>
        /// <param name="includeMarketCap">to include market_cap</param>
        /// <param name="include24HVol">to include 24hr_vol</param>
        /// <param name="include24HChange">to include 24hr_change</param>
        /// <param name="includeLastUpdatedAt">to include last_updated_at of price</param>
        /// <returns></returns>
        Task<Price> GetSimplePrice(string[] ids, string[] vsCurrencies,bool includeMarketCap,
            bool include24HVol,bool include24HChange,bool includeLastUpdatedAt);

        /// <summary>
        /// Get list of Supported vs currencies.
        /// </summary>
        /// <returns></returns>
        Task<SupportedCurrencies> GetSupportedVsCurrencies();
    }
}