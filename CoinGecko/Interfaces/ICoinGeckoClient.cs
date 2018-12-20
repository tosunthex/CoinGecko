namespace CoinGecko.Interfaces
{
    public interface ICoinGeckoClient
    {
        ICoinsClient CoinsClient { get; }
        IEventsClient EventsClient { get; }
        IExchangeRatesClient ExchangeRatesClient { get; }
        IExchangesClient ExchangesClient { get; }
    }
}