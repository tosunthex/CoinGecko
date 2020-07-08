using System.Dynamic;

namespace CoinGecko.ApiEndPoints
{
    public static class IndexesApiEndPointUrl
    {
        public static readonly string IndexesUrl = "indexes";
        public static readonly string IndexesList = IndexesUrl + "/list";
        public static string IndexesWithId(string id) => IndexesUrl + "/" + id;
    }
}