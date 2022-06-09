using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.Derivatives;
using CoinGecko.Interfaces;

using Newtonsoft.Json;

namespace CoinGecko.Clients
{
    public class DerivativesClient:BaseApiClient,IDerivativesClient
    {
        public DerivativesClient(HttpClient httpClient, JsonSerializerSettings serializerSettings) : base(httpClient, serializerSettings)
        {
        }

        public DerivativesClient(HttpClient httpClient, JsonSerializerSettings serializerSettings, string apiKey) : base(httpClient, serializerSettings, apiKey)
        {
        }


        public async Task<IReadOnlyList<Derivatives>> GetDerivatives()
        {
            return await GetDerivatives("").ConfigureAwait(false);
        }

        public async Task<IReadOnlyList<Derivatives>> GetDerivatives(string includeTicker)
        {
            return await GetAsync<IReadOnlyList<Derivatives>>(AppendQueryString(
                DerivativesApiEndPoints.DerivativesUrl, new Dictionary<string, object>
                {
                    {"include_ticker",includeTicker}
                })).ConfigureAwait(false);
        }

        public async Task<IReadOnlyList<DerivativesExchanges>> GetDerivativesExchanges()
        {
            return await GetDerivativesExchanges("", null, null).ConfigureAwait(false);
        }

        public async Task<IReadOnlyList<DerivativesExchanges>> GetDerivativesExchanges(string order, int? perPage, int? page)
        {
            return await GetAsync<IReadOnlyList<DerivativesExchanges>>(AppendQueryString(
                DerivativesApiEndPoints.DerivativesExchanges,new Dictionary<string, object>
                {
                    {"order",order},
                    {"per_page",perPage},
                    {"page",page}
                })).ConfigureAwait(false);
        }

        public async Task<DerivativesExchanges> GetDerivativesExchangesById(string id)
        {
            return await GetDerivativesExchangesById(id, "").ConfigureAwait(false);
        }

        public async Task<DerivativesExchanges> GetDerivativesExchangesById(string id, string includeTickers)
        {
            return await GetAsync<DerivativesExchanges>(AppendQueryString(
                DerivativesApiEndPoints.DerivativesExchangeById(id), new Dictionary<string, object>
                {
                    {"include_tickers", includeTickers}
                })).ConfigureAwait(false);
        }

        public async Task<IReadOnlyList<DerivativesExchangesList>> GetDerivativesExchangesList()
        {
            return await GetAsync<IReadOnlyList<DerivativesExchangesList>>(
                    AppendQueryString(DerivativesApiEndPoints.DerivativesExchangesList))
                .ConfigureAwait(false);
        }
    }
}