using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icertainty
{
    public class PriceCheck
    {
		public static int Check(string[] products, double[] productPrices, string[] productsSold, double[] soldPrices)
        {
			int incorrectPrices = 0;

			for (int i = 0; i < products.Length; i++)
			{
				string currentProduct = products[i];
				double actualPrice = productPrices[i];

				for (int j = 0; j < productsSold.Length; j++)
				{
					if (productsSold[j] == currentProduct && soldPrices[j] != actualPrice)
					{
						incorrectPrices += 1;
					}
				}
			}

			return incorrectPrices;
		}
    }
}