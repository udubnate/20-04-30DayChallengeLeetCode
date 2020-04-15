using System;
using System.Linq;

namespace Day15_ProductofArrayExceptSelf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:  [1,2,3,4]
            //Output: [24, 12, 8, 6]
            string input = "[1,2,3,4]";
            int[] nums = getIntArray(input);
            Solution s = new Solution();
            int[] output = s.ProductExceptSelf(nums);
            string str = String.Join(',', output);
            Console.WriteLine(str);
        }

        static int[] getIntArray(string str)
        {
            str = str.Trim('[', ']');
            int[] nums = str.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            return nums;
        }
    }
}
