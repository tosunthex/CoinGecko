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
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="contractAddress"></param>
        /// <returns></returns>
        Task<ContractData> GetContractData(string id, string contractAddress);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="contractAddress"></param>
        /// <param name="vsCurrency"></param>
        /// <param name="days"></param>
        /// <returns></returns>
        Task<MarketChartByContract> GetMarketChartByContract(string id, string contractAddress, string vsCurrency,
            string days);

        Task<MarketChartRangeByContract> GetMarketChartRangeByContract(string id, string contractAddress,
            string vsCurrency, string from, string to);
    }
}