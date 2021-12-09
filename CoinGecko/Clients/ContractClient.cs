using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.Coins;
using CoinGecko.Entities.Response.Contract;
using CoinGecko.Interfaces;
using CoinGecko.Services;
using Newtonsoft.Json;

namespace CoinGecko.Clients
{
    public class ContractClient : BaseApiClient, IContractClient
    {
        public ContractClient(HttpClient httpClient, JsonSerializerSettings serializerSettings) : base(httpClient, serializerSettings)
        {
        }
        public async Task<ContractData> GetContractData(string id, string contractAddress)
        {
            return await GetAsync<ContractData>(QueryStringService.AppendQueryString(
                ContractApiEndPoints.ContractDetailAddress(id, contractAddress)))
                .ConfigureAwait(false);
        }

        public async Task<MarketChartByContract> GetMarketChartByContract(string id,
            string contractAddress, string vsCurrency, string days)
        {
            return await GetAsync<MarketChartByContract>(QueryStringService.AppendQueryString(
                ContractApiEndPoints.MarketChartByContractAddress(id,contractAddress),new Dictionary<string, object>
                {
                    {"vs_currency",vsCurrency},
                    {"days",days}
                }
            ));
        }

        public async Task<MarketChartRangeByContract> GetMarketChartRangeByContract(string id, string contractAddress, string vsCurrency, string @from, string to)
        {
            return await GetAsync<MarketChartRangeByContract>(QueryStringService.AppendQueryString(
                ContractApiEndPoints.MarketChartRangeByContractAddress(id, contractAddress),new Dictionary<string, object>
                {
                    {"vs_currency",vsCurrency},
                    {"from",from},
                    {"to",to},
                }
            ));
        }
    }
}