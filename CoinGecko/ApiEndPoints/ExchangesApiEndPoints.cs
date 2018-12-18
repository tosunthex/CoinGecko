using CoinGecko.Entities.Response.Exchanges;

namespace CoinGecko.ApiEndPoints
{
    public class ExchangesApiEndPoints
    {
        public static readonly string Exchanges = "exchages";
        public static string ExchangeById(string id) => "exchages/"+id;
        public static string TickerById(string id) => "exchages/"+id+"/tickers";
    }
}