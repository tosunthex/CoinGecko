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

        public BaseApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<T> GetAsync<T>(Uri resourceUri)
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
                /*var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(responseContent);
                var errorMessage =
                    $"{errorResponse.Type} : {errorResponse.Message} {errorResponse.ErrorSummary} {errorResponse.Path} {e.Message}";*/
                //Todo Error Message 
                throw new HttpRequestException("Error Message");
            }
        }
    }
}