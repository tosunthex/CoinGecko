using System;
using System.Net.Http;
using CoinGecko.Interfaces;

namespace CoinGecko.Clients
{
    public partial class CoinGeckoClient: IDisposable,ICoinGeckoClient
    {
        private static readonly Lazy<CoinGeckoClient> Lazy = new Lazy<CoinGeckoClient>(() => new CoinGeckoClient());

        private readonly HttpClient _httpClient;
        private bool _isDisposed;

        public CoinGeckoClient(HttpClientHandler httpClientHandler)
        {
            _httpClient = new HttpClient(httpClientHandler,true);
        }

        public CoinGeckoClient() : this(new HttpClientHandler())
        {
        }

        public static CoinGeckoClient Instance => Lazy.Value;
        
        public SimpleClient SimpleClient => new SimpleClient(_httpClient);
        public PingClient PingClient => new PingClient(_httpClient);
        public ICoinsClient CoinsClient => new CoinsClient(_httpClient);
        public IExchangesClient ExchangesClient => new ExchangesClient(_httpClient);
        public IEventsClient EventsClient => new EventsClient(_httpClient);
        public IExchangeRatesClient ExchangeRatesClient => new ExchangeRatesClient(_httpClient);
        public IGlobalClient GlobalClient => new GlobalClient(_httpClient);
        
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