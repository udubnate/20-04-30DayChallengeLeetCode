using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace Day22_SubarraySumEqualsK
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 1,1,1 };
            Solution s = new Solution();
            int output = s.SubarraySum(input, 2);

            Console.WriteLine("Output = " + output);
        }
    }

    public class Solution
    {
        public int SubarraySum(int[] nums, int k)
        {
            int count = 0;

            for (int start = 0; start < nums.Length; start++)
            {
                for (int end = start + 1; end <= nums.Length; end++)
                {
                    int sum = 0;
                    for (int i = start; i < end; i++)
                    {
                        sum += nums[i];
                    }
                    if (sum == k)
                    {
                        count++;
                    }
                    
                }
            }
            return count;

        }
    }
}
