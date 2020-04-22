﻿using System;
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
            int[] sum = new int[nums.Length + 1];
            sum[0] = 0;
            for (int i = 1; i <= nums.Length; i++)
            {
                sum[i] = sum[i - 1] + nums[i - 1];
            }
            for (int start = 0; start < nums.Length; start++)
            {
                for (int end = start  + 1; end <= nums.Length; end++)
                {
                    if (sum[end] - sum[start] == k)
                    {
                        count++;
                    }
                }
            }
           return count;

        }
    }
}
