using System;
using System.Net.Http;
using CoinGecko.Interfaces;
using Newtonsoft.Json;

namespace CoinGecko.Clients
{
    public partial class CoinGeckoClient : IDisposable, ICoinGeckoClient
    {
        private static readonly Lazy<CoinGeckoClient> Lazy = new Lazy<CoinGeckoClient>(() => new CoinGeckoClient());

        private readonly HttpClient _httpClient;
        private bool _isDisposed;
        private readonly JsonSerializerSettings _serializerSettings;
        private readonly string _apiKey;

        public CoinGeckoClient(string apiKey = null) : this((JsonSerializerSettings)null, apiKey)
        {
        }

        public CoinGeckoClient(HttpClientHandler httpClientHandler, string apiKey = null) : this(httpClientHandler, null, apiKey)
        {
            _apiKey = apiKey;
        }

        public CoinGeckoClient(JsonSerializerSettings serializerSettings, string apiKey = null) : this(new HttpClientHandler(), serializerSettings, apiKey)
        {
        }

        public CoinGeckoClient(HttpClientHandler httpClientHandler, JsonSerializerSettings serializerSettings, string apiKey = null)
            : this(new HttpClient(httpClientHandler, true), serializerSettings, apiKey)
        {
        }

        public CoinGeckoClient(HttpClient httpClient, string apiKey = null) : this(httpClient, null, apiKey)
        {
        }

        public CoinGeckoClient(HttpClient httpClient, JsonSerializerSettings serializerSettings, string apiKey = null)
        {
            _httpClient = httpClient;
            _serializerSettings = serializerSettings;
            _apiKey = apiKey;
        }

        public static CoinGeckoClient Instance => Lazy.Value;

        public ISimpleClient SimpleClient => new SimpleClient(_httpClient, _serializerSettings,_apiKey);
        public IPingClient PingClient => new PingClient(_httpClient, _serializerSettings, _apiKey);
        public ICoinsClient CoinsClient => new CoinsClient(_httpClient, _serializerSettings, _apiKey);
        public IExchangesClient ExchangesClient => new ExchangesClient(_httpClient, _serializerSettings, _apiKey);
        public IEventsClient EventsClient => new EventsClient(_httpClient, _serializerSettings, _apiKey);
        public IExchangeRatesClient ExchangeRatesClient => new ExchangeRatesClient(_httpClient, _serializerSettings, _apiKey);
        public IGlobalClient GlobalClient => new GlobalClient(_httpClient, _serializerSettings, _apiKey);
        public IContractClient ContractClient => new ContractClient(_httpClient, _serializerSettings, _apiKey);
        public IFinancePlatformsClient FinancePlatformsClient => new FinancePlatformsClient(_httpClient, _serializerSettings, _apiKey);
        public IIndexesClient IndexesClient => new IndexesClient(_httpClient, _serializerSettings, _apiKey);
        public IDerivativesClient DerivativesClient => new DerivativesClient(_httpClient, _serializerSettings, _apiKey);
        public IStatusUpdatesClient StatusUpdatesClient => new StatusUpdateClient(_httpClient, _serializerSettings, _apiKey);
        public ISearchClient SearchClient => new SearchClient(_httpClient, _serializerSettings, _apiKey);


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposed)
            {
                return;
            }
            if (disposing)
            {
                _httpClient?.Dispose();
            }
            _isDisposed = true;
        }
    }
}