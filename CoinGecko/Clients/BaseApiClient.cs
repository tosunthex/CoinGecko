using System;
using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.Interfaces;
using Newtonsoft.Json;

namespace CoinGecko.Clients
{
    public class BaseApiClient:IAsyncApiRepository
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerSettings _serializerSettings;

        public BaseApiClient(HttpClient httpClient, JsonSerializerSettings serializerSettings)
        {
            _httpClient = httpClient;
            _serializerSettings = serializerSettings;
        }

        public async Task<T> GetAsync<T>(Uri resourceUri)
        {
            //_httpClient.DefaultRequestHeaders.Add("User-Agent", "your bot 0.1");
            var response = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, resourceUri))
                .ConfigureAwait(false);
            
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            try
            {
                return JsonConvert.DeserializeObject<T>(responseContent, _serializerSettings);
            }
            catch (Exception e)
            {
                throw new HttpRequestException(e.Message);
            }
        }
    }
}