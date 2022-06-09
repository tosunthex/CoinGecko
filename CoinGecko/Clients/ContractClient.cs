using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.Contract;
using CoinGecko.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoinGecko.Clients
{
    public class ContractClient : BaseApiClient, IContractClient
    {
        public ContractClient(HttpClient httpClient, JsonSerializerSettings serializerSettings) : base(httpClient, serializerSettings)
        {
        }

        public ContractClient(HttpClient httpClient, JsonSerializerSettings serializerSettings, string apiKey) : base(httpClient, serializerSettings, apiKey)
        {
        }

        public async Task<ContractData> GetContractData(string id, string contractAddress)
        {
            return await GetAsync<ContractData>(AppendQueryString(
                ContractApiEndPoints.ContractDetailAddress(id, contractAddress)))
                .ConfigureAwait(false);
        }

        public async Task<MarketChartByContract> GetMarketChartByContract(string id,
            string contractAddress, string vsCurrency, string days)
        {
            return await GetAsync<MarketChartByContract>(AppendQueryString(
                ContractApiEndPoints.MarketChartByContractAddress(id, contractAddress), new Dictionary<string, object>
                {
                    {"vs_currency",vsCurrency},
                    {"days",days}
                }
            ));
        }

        public async Task<MarketChartRangeByContract> GetMarketChartRangeByContract(string id, string contractAddress, string vsCurrency, string @from, string to)
        {
            return await GetAsync<MarketChartRangeByContract>(AppendQueryString(
                ContractApiEndPoints.MarketChartRangeByContractAddress(id, contractAddress), new Dictionary<string, object>
                {
                    {"vs_currency",vsCurrency},
                    {"from",from},
                    {"to",to},
                }
            ));
        }
    }
}