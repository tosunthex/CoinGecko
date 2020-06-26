using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CoinGecko.Entities.Response.Coins;
using CoinGecko.Entities.Response.Contract;

namespace CoinGecko.Interfaces
{
    public interface IContractClient
    {
        /// <summary>
        /// Get coin info from contract address
        /// </summary>
        /// <param name="id">Asset platform (only ethereum is supported at this moment)</param>
        /// <param name="contractAddress">Token’s contract address</param>
        /// <returns></returns>
        Task<ContractData> GetContractData(string id, string contractAddress);

        /// <summary>
        /// Get historical market data include price, market cap, and 24h volume (granularity auto) from a contract address
        /// </summary>
        /// <param name="id">The id of the platform issuing tokens (Only ethereum is supported for now)</param>
        /// <param name="contractAddress">Token’s contract address</param>
        /// <param name="vsCurrency">The target currency of market data (usd, eur, jpy, etc.)</param>
        /// <param name="days">Data up to number of days ago (eg. 1,14,30,max)</param>
        /// <returns></returns>
        Task<MarketChartByContract> GetMarketChartByContract(string id, string contractAddress, string vsCurrency,
            string days);

        /// <summary>
        /// Get historical market data include price, market cap, and 24h volume within a range of timestamp (granularity auto) from a contract address
        /// </summary>
        /// <param name="id">The id of the platform issuing tokens (Only ethereum is supported for now)</param>
        /// <param name="contractAddress">Token’s contract address</param>
        /// <param name="vsCurrency">The target currency of market data (usd, eur, jpy, etc.)</param>
        /// <param name="from">From date in UNIX Timestamp (eg. 1392577232)</param>
        /// <param name="to">To date in UNIX Timestamp (eg. 1422577232)</param>
        /// <returns></returns>
        Task<MarketChartRangeByContract> GetMarketChartRangeByContract(string id, string contractAddress,
            string vsCurrency, string from, string to);
    }
}