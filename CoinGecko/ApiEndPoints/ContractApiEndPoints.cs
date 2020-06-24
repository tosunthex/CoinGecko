namespace CoinGecko.ApiEndPoints
{
    public static class ContractApiEndPoints
    {
        public static string ContractDetailAddress(string id, string contractAddress) =>
            BaseApiEndPointUrl.AddCoinsIdUrl(id) + "/contract/" + contractAddress;

        public static string MarketChartByContractAddress(string id, string contractAddress) =>
            BaseApiEndPointUrl.AddCoinsIdUrl(id) + "/contract/" + contractAddress + "/market_chart/";
        public static string MarketChartRangeByContractAddress(string id, string contractAddress) =>
            BaseApiEndPointUrl.AddCoinsIdUrl(id) + "/contract/" + contractAddress + "/market_chart/range";
    }
}
