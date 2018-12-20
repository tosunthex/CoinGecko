using System.Threading.Tasks;
using CoinGecko.Entities.Response;

namespace CoinGecko.Interfaces
{
    public interface IPingClient
    {
        /// <summary>
        /// Check API server status
        /// </summary>
        /// <returns></returns>
        Task<Ping> GetPingAsync();
    }
}