using System;

namespace Day6_GroupAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string[] nums = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            s.GroupAnagrams(nums);

            Console.WriteLine("Hello World!");
        }
    }
}
