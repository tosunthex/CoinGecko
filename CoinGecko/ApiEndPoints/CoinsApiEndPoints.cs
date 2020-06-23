using System.Runtime.InteropServices.ComTypes;

namespace CoinGecko.ApiEndPoints
{
    public static class CoinsApiEndPoints
    {
        public static readonly string Coins = "coins";
        public static readonly string CoinList = Coins + "/list";
        public static readonly string CoinMarkets = Coins + "/markets";
        public static string CoinsWithIdUrl(string id) => Coins + "/" + id;
        public static string AllDataByCoinId(string id) => CoinsWithIdUrl(id);
        public static string TickerByCoinId(string id) => CoinsWithIdUrl(id) + "/tickers";
        public static string HistoryByCoinId(string id) => CoinsWithIdUrl(id) + "/history";
        public static string MarketChartByCoinId(string id) => CoinsWithIdUrl(id) + "/market_chart";
        public static string MarketChartRangeByCoinId(string id) => CoinsWithIdUrl(id) + "/market_chart/range";
        public static string StatusUpdates(string id) => CoinsWithIdUrl(id) + "/status_updates";
    }
}