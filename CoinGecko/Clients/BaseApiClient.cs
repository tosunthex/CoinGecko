using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using CoinGecko.Interfaces;
using Newtonsoft.Json;

namespace CoinGecko.Clients
{
    public class BaseApiClient:IAsyncApiRepository
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerSettings _serializerSettings;
        private readonly string _apiKey;

        public BaseApiClient(HttpClient httpClient, JsonSerializerSettings serializerSettings, string apiKey)
        {
            _httpClient = httpClient;
            _serializerSettings = serializerSettings;
            _apiKey = apiKey;
        }

        public async Task<T> GetAsync<T>(Uri resourceUri)
        {
            if (!string.IsNullOrEmpty(_apiKey)) {
                resourceUri = AddParameter(resourceUri, "x_cg_pro_api_key", _apiKey);
            }

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


        /// <summary>
        /// Adds the specified parameter to the Query String.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="paramName">Name of the parameter to add.</param>
        /// <param name="paramValue">Value for the parameter to add.</param>
        /// <returns>Url with added parameter.</returns>
        private Uri AddParameter(Uri url, string paramName, string paramValue)
        {
            var uriBuilder = new UriBuilder(url);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query[paramName] = paramValue;
            uriBuilder.Query = query.ToString();

            return uriBuilder.Uri;
        }
    }
}