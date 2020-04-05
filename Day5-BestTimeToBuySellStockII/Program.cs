using System;
using System.Collections.Generic;

namespace Day5_BestTimeToBuySellStockII
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            List<int[]> IntArray = new List<int[]>
            {
                new int[] { 7, 1, 5, 3, 6, 4 },
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 7, 6, 4, 3, 1}
            };

            int count = 0;
            foreach (int[] nums in IntArray){
                Console.WriteLine("Test # " + count + " [" + String.Join(',', nums) + "] ::");
                int maxprofit = s.MaxProfit(nums);
                Console.WriteLine(maxprofit.ToString());
                count++;
            }
            
        }
    }
}
