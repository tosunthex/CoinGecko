namespace CoinGecko.ApiEndPoints
{
    public class DerivativesApiEndPoints
    {
        public static readonly string DerivativesUrl = "derivatives";
        public static readonly string DerivativesExchanges = DerivativesUrl + "/exchanges";
        public static readonly string DerivativesExchangesList = DerivativesExchanges + "/list";
        public static string DerivativesExchangeById(string id) => DerivativesExchanges + "/" + id;
        
    }
}