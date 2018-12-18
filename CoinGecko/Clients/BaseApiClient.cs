using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoinGecko.Clients
{
    public class BaseApiClient
    {
        private readonly HttpClient _httpClient;

        public BaseApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        protected async Task<T> GetAsync<T>(Uri resourceUri)
        {
            var response = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, resourceUri))
                .ConfigureAwait(false);
            
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            try
            {
                return JsonConvert.DeserializeObject<T>(responseContent);
            }
            catch (Exception e)
            {
                throw new HttpRequestException(e.Message);
            }
        }
    }
}