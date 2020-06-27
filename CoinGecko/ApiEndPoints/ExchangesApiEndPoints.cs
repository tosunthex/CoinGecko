namespace CoinGecko.ApiEndPoints
{
    public static class ExchangesApiEndPoints
    {
        public static readonly string Exchanges = "exchanges";
        public static readonly string ExchangesList = "exchanges/list";
        public static string ExchangeById(string id) => "exchanges/"+id;
        public static string TickerById(string id) => "exchanges/"+id+"/tickers";
        public static string VolumeChartById(string id) => "exchanges/"+id+ "/volume_chart";
    }
}