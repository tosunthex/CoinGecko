using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.Contract;
using CoinGecko.Interfaces;
using CoinGecko.Services;

namespace CoinGecko.Clients
{
    public class ContractClient : BaseApiClient, IContractClient
    {
        public ContractClient(HttpClient httpClient) : base(httpClient)
        {
        }
        public async Task<ContractData> GetContractDataByIdAndContractAddress(string id, string contractAddress)
        {
            return await GetAsync<ContractData>(QueryStringService.AppendQueryString(
                ContractApiEndPoints.ContractDetailByIdContractAddress(id, contractAddress)))
                .ConfigureAwait(false);
        }


    }
}