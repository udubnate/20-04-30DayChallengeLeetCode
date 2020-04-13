using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Day13_ContiguousArray
{

    //Given a binary array, find the maximum length of a contiguous subarray with equal number of 0 and 1.
    // solution help from : https://leetcode.com/problems/contiguous-array/discuss/99691/C-single-pass-O(n)-space

    public class Solution
    {
        public int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int max = 0;
            int sum = 0;
            dict[0] = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i] == 0 ? -1 : 1;
                if (dict.ContainsKey(sum))
                {
                    max = Math.Max(max, i - dict[sum]);
                }
                else
                {
                    dict[sum] = i;
                }
            }

            return max;
        }
    }
    }

