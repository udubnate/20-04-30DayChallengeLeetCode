using System;

namespace Day13_ContiguousArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //int[] nums = new int[] { 1,1,0,0,1,1,0 };
            //int[] nums = new int[] { 1, 0 };
            int[] nums = new int[] { 0, 0, 1, 0, 0, 0, 1, 1 };
            Console.WriteLine(s.FindMaxLength(nums).ToString());
        }
    }
}
