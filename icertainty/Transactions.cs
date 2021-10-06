using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icertainty
{
    public class Transactions
    {
        public static string[] GroupTransactions(string[] transactions)
        {
            var groupedTransactions = transactions.GroupBy(transaction => transaction)
                                 .ToDictionary(item => item.Key, item => item.Count())
                                 .OrderByDescending(item => item.Value)
                                 .ThenBy(item => item.Key)
                                 .Select(transaction => transaction.Key + " " + transaction.Value);

            return groupedTransactions.ToArray();
        }
    }
}
