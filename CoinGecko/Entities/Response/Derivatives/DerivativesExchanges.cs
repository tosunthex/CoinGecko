using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoinGecko.Entities.Response.Derivatives
{
    public class DerivativesExchanges
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("open_interest_btc")]
        public double? OpenInterestBtc { get; set; }

        [JsonProperty("trade_volume_24h_btc")]
        public string TradeVolume24HBtc { get; set; }

        [JsonProperty("number_of_perpetual_pairs")]
        public long? NumberOfPerpetualPairs { get; set; }

        [JsonProperty("number_of_futures_pairs")]
        public long? NumberOfFuturesPairs { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("year_established")]
        public long? YearEstablished { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
        
        [JsonProperty("tickers")]
        public IReadOnlyList<DerivativesTicker> Tickers { get; set; }
    }
}