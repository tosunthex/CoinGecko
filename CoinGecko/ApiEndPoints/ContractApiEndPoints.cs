using System;
using System.Collections.Generic;
using System.Text;

namespace CoinGecko.ApiEndPoints
{
    public static class ContractApiEndPoints
    {
        private static string CoinsWithIdUrl(string id) => "coins/" + id;
        public static string ContractDetailByIdContractAddress(string id, string contractAddress) =>
            CoinsWithIdUrl(id) + "/contract/"+contractAddress;

        
    }
}
