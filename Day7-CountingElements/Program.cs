using System;
using System.Linq;

namespace Day7_CountingElements
{
    //Given an integer array arr, count element x such that x + 1 is also in arr.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give an array to test:");
            String str = Console.ReadLine();
            int[] nums = str.Split(',').Select(int.Parse).ToArray();

            Solution s = new Solution();
            Console.WriteLine(s.CountElements(nums).ToString());

        }
    }
}
