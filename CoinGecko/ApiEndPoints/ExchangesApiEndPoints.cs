namespace CoinGecko.ApiEndPoints
{
    public class ExchangesApiEndPoints
    {
        public static readonly string Exchanges = "exchanges";
        public static string ExchangeById(string id) => "exchanges/"+id;
        public static string TickerById(string id) => "exchanges/"+id+"/tickers";
    }
}