using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_BestTimeToBuySellStockII
{
    class Solution
    {
        public int MaxProfit(int[] prices)
        {
            bool buy = true;
            int profit = 0;
            int transaction = 0;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                //Check to Buy 
                if ((prices[i] - prices[i + 1]) < 0 && buy)
                {
                    //trigger buy
                    transaction += prices[i];
                    buy = false;
                    Console.WriteLine("Day " + (i + 1).ToString() + " :: Buy");
                }
                else if ((prices[i] - prices[i + 1]) > 0 && !buy)
                {
                    //trigger sell
                    transaction = prices[i] - transaction;
                    profit += transaction;
                    transaction = 0;
                    Console.WriteLine("Day " + (i + 1).ToString() + " :: Sell");
                    buy = true;
                }
                //if you are at the last element and you haven't sold yet
                if (!buy && (i == prices.Length - 2))
                {
                    //trigger sell
                    transaction = prices[i+1] - transaction;
                    profit += transaction;
                    transaction = 0;
                    Console.WriteLine("Day " + (i + 2).ToString() + " :: Sell");
                    buy = true;
                }
            }
            return profit;
        }

    }
}
