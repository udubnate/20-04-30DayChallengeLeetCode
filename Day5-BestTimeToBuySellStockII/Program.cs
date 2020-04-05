using System;

namespace Day5_BestTimeToBuySellStockII
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] nums = new int[] { 7, 1, 5, 3, 6, 4 };
            //nums = new int[] { 1, 2, 3, 4, 5 };
            nums = new int[] { 7, 6, 4, 3, 1};
            int maxprofit = s.MaxProfit(nums);
            Console.WriteLine(maxprofit.ToString());
        }
    }
}
