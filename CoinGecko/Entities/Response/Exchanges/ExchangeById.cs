using System;
using CoinGecko.Entities.Response.Shared;
using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Exchanges
{
    public class ExchangeById:Exchanges
    {
        [JsonProperty("tickers")]
        public Ticker[] Tickers { get; set; }

        [JsonProperty("status_updates")]
        public object[] StatusUpdates { get; set; }
    }
}