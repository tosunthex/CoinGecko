using System.Threading.Tasks;
using CoinGecko.Entities.Response.ExchangeRates;

namespace CoinGecko.Interfaces
{
    public interface IExchangeRatesClient
    {
        /// <summary>
        /// Get BTC-to-Currency exchange rates
        /// </summary>
        /// <returns></returns>
        Task<ExchangeRates> GetExchangeRates();
    }
}