using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using CoinGecko.Entities.Response.Contract;

namespace CoinGecko.Interfaces
{
    public interface IContractClient
    {
        Task<ContractData> GetContractDataByIdAndContractAddress(string id, string contractAddress);
    }
}