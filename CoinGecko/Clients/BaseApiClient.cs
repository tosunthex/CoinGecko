using CoinGecko.ApiEndPoints;
using CoinGecko.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace CoinGecko.Clients
{
    public class BaseApiClient : IAsyncApiRepository
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerSettings _serializerSettings;
        private readonly string _apiKey;
        private readonly bool _isProMode;

        public BaseApiClient(HttpClient httpClient, JsonSerializerSettings serializerSettings, string apiKey, bool isPublicApiForced)
        {
            _httpClient = httpClient;
            _serializerSettings = serializerSettings;
            _apiKey = apiKey;

            if (isPublicApiForced)
            {
	            _isProMode = false;
            }
            else if(!string.IsNullOrEmpty(apiKey))
            {
	            _isProMode = true;
            }
        }

        public BaseApiClient(HttpClient httpClient, JsonSerializerSettings serializerSettings, string apiKey): this(httpClient, serializerSettings, apiKey, false)
        {
        }


		public BaseApiClient(HttpClient httpClient, JsonSerializerSettings serializerSettings)
        {
            _httpClient = httpClient;
            _serializerSettings = serializerSettings;
        }

        public async Task<T> GetAsync<T>(Uri resourceUri)
        {
	        if (!string.IsNullOrEmpty(_apiKey))
	        {
		        if (_isProMode)
		        {
			        resourceUri = AddParameter(resourceUri, "x_cg_pro_api_key", _apiKey);
		        }
		        else
		        {
			        resourceUri = AddParameter(resourceUri, "x_cg_demo_api_key", _apiKey);
		        }
	        }

	        _httpClient.DefaultRequestHeaders.Add("User-Agent", "your bot 0.1");
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

        public Uri AppendQueryString(string path, Dictionary<string, object> parameter) => CreateUrl(path, parameter);

        public Uri AppendQueryString(string path) => CreateUrl(path, new Dictionary<string, object>());

        private Uri CreateUrl(string path, Dictionary<string, object> parameter)
        {
            var urlParameters = new List<string>();
            foreach (var par in parameter)
            {
                urlParameters.Add(par.Value == null || string.IsNullOrWhiteSpace(par.Value.ToString())
                    ? null
                    : $"{par.Key}={par.Value}");
            }

            var encodedParams = urlParameters
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(WebUtility.HtmlEncode)
                .Select((x, i) => i > 0 ? $"&{x}" : $"?{x}")
                .ToArray();
            var url = encodedParams.Length > 0 ? $"{path}{string.Join(string.Empty, encodedParams)}" : path;

            //using pro API url if apiKey is set and public mode not forced
            return new Uri(_isProMode ? BaseApiEndPointUrl.ProApiEndPoint : BaseApiEndPointUrl.ApiEndPoint, url);
        }
    }
}