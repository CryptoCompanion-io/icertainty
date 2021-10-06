using Microsoft.VisualStudio.TestTools.UnitTesting;
using icertainty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icertainty.Tests
{
    [TestClass()]
    public class TransactionsTests
    {
        [TestMethod()]
        public void GroupTransactionsTest1()
        {
            string[] transactions = { "notebook", "notebook", "mouse", "keyboard", "mouse" };
            string[] result = new[] { "mouse 2", "notebook 2", "keyboard 1" };

            string[] grouped = Transactions.GroupTransactions(transactions);

            CollectionAssert.AreEqual(grouped, result);
        }

        [TestMethod()]
        public void GroupTransactionsTest2()
        {
            string[] transactions = { "notebook", "keyboard", "mouse", "mouse", "notebook", "mouse" };
            string[] result = new[] { "mouse 3", "notebook 2", "keyboard 1" };

            string[] grouped = Transactions.GroupTransactions(transactions);

            CollectionAssert.AreEqual(grouped, result);
        }

        [TestMethod()]
        public void GroupTransactionsTest3()
        {
            string[] transactions = { "notebook", "notebook", "mouse", "monitor", "monitor", "mouse", "keyboard", "notebook", "monitor" };
            string[] result = new[] { "monitor 3", "notebook 3", "mouse 2", "keyboard 1"};

            string[] grouped = Transactions.GroupTransactions(transactions);


            CollectionAssert.AreEqual(grouped, result);
        }

    }
}