namespace CoinGecko.ApiEndPoints
{
    public static class CoinsApiEndPoints
    {
        public static readonly string Coins = "coins";
        public static readonly string CoinList = "coins/list";
        public static readonly string CoinMarkets = "coins/markets";
        public static string AllDataWithCoinId(string id) => "coins/" + id;
        public static string TickerWithCoinId(string id) => "coins/" + id + "/ticker";
        
    }
}