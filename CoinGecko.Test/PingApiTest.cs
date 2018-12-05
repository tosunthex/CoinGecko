using System;
using System.Linq;
using CoinGecko.Clients;
using Xunit;

namespace CoinGecko.Test
{
    public class PingApiTest
    {
        private readonly CoinGeckoClient _client;
        public PingApiTest()
        {
            _client = CoinGeckoClient.Instance;
        }
        [Fact]
        public async void Ping_Method_Must_Return_ToTheMoon()
        {
            var result = await _client.PingClient.GetPingAsync();
            Assert.Equal("(V3) To the Moon!",result.GeckoSays);
        }
        [Fact]
        public async void BTC_To_ETH_Convert_Must_Not_Null()
        {
            var result = await _client.SimpleClient.GetSimplePrice(new []{"bitcoin"},new []{"eth"});
            Console.WriteLine(result["BITCOIN"]["ETH"].Value);
            Assert.False(string.IsNullOrEmpty(result["BITCOIN"]["ETH"].Value.ToString()));
        }
        [Fact]
        public async void Supported_Vs_Currencies_Must_Cointains_BTC_ETH()
        {
            var result = await _client.SimpleClient.GetSupportedVsCurrencies();
            
            Assert.True(result.Contains("btc"));
            Assert.True(result.Contains("eth"));
        }
    }
}