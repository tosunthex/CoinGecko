using System.Threading.Tasks;
using CoinGecko.Clients;
using CoinGecko.Interfaces;
using Xunit;

namespace CoinGecko.Test
{
    public class ContractClientTests
    {
        private readonly ICoinGeckoClient _client;

        public ContractClientTests()
        {
            _client = CoinGeckoClient.Instance;
        }

        [Fact]
        public async Task Get_Contract_Data_for_Eth_Bat()
        {
            var result = await 
                _client.ContractClient.GetContractDataByIdAndContractAddress("ethereum",
                    "0x0D8775F648430679A709E98d2b0Cb6250d2887EF");
            Assert.Equal("basic-attention-token", result.Id);
        }
    }
}