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

        public CoinGeckoClient() : this((JsonSerializerSettings)null)
        {
        }

        public CoinGeckoClient(HttpClientHandler httpClientHandler) : this(httpClientHandler, null)
        {
        }

        public CoinGeckoClient(JsonSerializerSettings serializerSettings) : this(new HttpClientHandler(), serializerSettings)
        {
        }

        public CoinGeckoClient(HttpClientHandler httpClientHandler, JsonSerializerSettings serializerSettings)
            : this(new HttpClient(httpClientHandler, true), serializerSettings)
        {
        }

        public CoinGeckoClient(HttpClient httpClient) : this(httpClient, null)
        {
        }

        public CoinGeckoClient(HttpClient httpClient, JsonSerializerSettings serializerSettings)
        {
            _httpClient = httpClient;
            _serializerSettings = serializerSettings;
        }

        public static CoinGeckoClient Instance => Lazy.Value;

        public ISimpleClient SimpleClient => new SimpleClient(_httpClient, _serializerSettings);
        public IPingClient PingClient => new PingClient(_httpClient, _serializerSettings);
        public ICoinsClient CoinsClient => new CoinsClient(_httpClient, _serializerSettings);
        public IExchangesClient ExchangesClient => new ExchangesClient(_httpClient, _serializerSettings);
        public IEventsClient EventsClient => new EventsClient(_httpClient, _serializerSettings);
        public IExchangeRatesClient ExchangeRatesClient => new ExchangeRatesClient(_httpClient, _serializerSettings);
        public IGlobalClient GlobalClient => new GlobalClient(_httpClient, _serializerSettings);
        public IContractClient ContractClient => new ContractClient(_httpClient, _serializerSettings);
        public IFinancePlatformsClient FinancePlatformsClient => new FinancePlatformsClient(_httpClient, _serializerSettings);
        public IIndexesClient IndexesClient => new IndexesClient(_httpClient, _serializerSettings);
        public IDerivativesClient DerivativesClient => new DerivativesClient(_httpClient, _serializerSettings);
        public IStatusUpdatesClient StatusUpdatesClient => new StatusUpdateClient(_httpClient, _serializerSettings);


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