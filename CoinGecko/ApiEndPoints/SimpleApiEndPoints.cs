namespace CoinGecko.ApiEndPoints
{
    public static class SimpleApiEndPoints
    {
        public static readonly string SimplePrice = "simple/price";
        public static readonly string SimpleSupportedVsCurrencies = "simple/supported_vs_currencies";
        public static string TokenPrice(string id) => "simple/token_price/"+ id;
    }
}