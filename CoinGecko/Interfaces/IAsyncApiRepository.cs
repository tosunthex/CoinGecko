using System;
using System.Threading.Tasks;

namespace CoinGecko.Interfaces
{
    public interface IAsyncApiRepository
    {
        /// <summary>
        ///     Sends an API request async using GET Method
        /// </summary>
        /// <param name="resourceUri">The resouce uri path</param>
        /// <returns>Asyncronous result turns by TApiResouce</returns>
        Task<T> GetAsync<T>(Uri resourceUri);
    }
}