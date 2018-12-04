using System;
using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Coins
{
    public class TickerByCoinId
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tickers")]
        public Ticker[] Tickers { get; set; }
    }
}