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
                _client.ContractClient.GetContractData("ethereum",
                    "0x0D8775F648430679A709E98d2b0Cb6250d2887EF");
            Assert.Equal("basic-attention-token", result.Id);
        }

        [Fact]
        public async Task Market_Chart_Price_Count_Must_Be_Equal_Marketcap_Count()
        {
            var result = await _client.ContractClient.GetMarketChartByContract("ethereum",
                "0x0D8775F648430679A709E98d2b0Cb6250d2887EF", "usd", "1");
            Assert.Equal(result.MarketCaps.Length,result.Prices.Length);
        }

        [Fact]
        public async Task Market_Chart_Range_Price_Count_Must_Be_Equal_Marketcap_Count()
        {
            var result = await _client.ContractClient.GetMarketChartRangeByContract("ethereum",
                "0x0D8775F648430679A709E98d2b0Cb6250d2887EF", "usd", "1577836800", "1592611200");
            Assert.Equal(result.MarketCaps.Length,result.Prices.Length);
        }

    }
}