using System;

namespace Day12_LastStoneWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] nums = new int[] { 2, 2};
            Console.WriteLine(s.LastStoneWeight(nums).ToString());
        }
    }
}
