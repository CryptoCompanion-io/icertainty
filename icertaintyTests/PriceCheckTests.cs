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
    public class PriceCheckTests
    {
        public string[] products = { "eggs", "milk", "cheese" };
        public double[] productPrices = { 2.89, 3.29, 5.79 };

        [TestMethod()]
        public void CheckTest1()
        {
            // Two errors expected
            string[] productsSold = { "eggs", "eggs", "cheese", "milk" };
            double[] soldPrices = { 2.89, 2.99, 5.97, 3.29 };

            int check = PriceCheck.Check(this.products, this.productPrices, productsSold, soldPrices);
            Assert.AreEqual(check, 2);
        }

        [TestMethod()]
        public void CheckTest2()
        {
            // Two errors expected
            string[] productsSold = { "eggs", "eggs", "cheese", "milk", "eggs", "cheese", "cheese", "milk" };
            double[] soldPrices = { 2.89, 2.99, 5.97, 3.34, 2.89, 5.98, 5.79, 3.29 };

            int check = PriceCheck.Check(this.products, this.productPrices, productsSold, soldPrices);
            Assert.AreEqual(check, 4);
        }

        [TestMethod()]
        public void CheckTest3()
        {
            // Three errors expected
            string[] productsSold = { "eggs", "cheese", "milk", "eggs", "cheese", "milk", "milk", "eggs" };
            double[] soldPrices = { 2.89, 5.79, 3.92, 2.80, 5.79, 3.29, 3.30, 2.89 };

            int check = PriceCheck.Check(this.products, this.productPrices, productsSold, soldPrices);
            Assert.AreEqual(check, 3);
        }
    }
}