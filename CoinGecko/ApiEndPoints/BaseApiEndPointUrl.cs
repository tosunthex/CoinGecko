using System;

namespace CoinGecko.ApiEndPoints
{
    public static class BaseApiEndPointUrl
    {
        public static readonly Uri ApiEndPoint = new Uri("https://api.coingecko.com/api/v3/");
        public static string AddCoinsIdUrl(string id) => "coins/" + id;
    }
}