using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Day3_Maximum_Subarray
{
    public class Solution
    {
        // still processing how coder came up with this solution but works really well
        // reference: https://leetcode.com/problems/maximum-subarray/discuss/20461/Accepted-C-solution

        public int MaxSubArray(int[] nums)
        {
            int sum = -1;
            int highest = nums[0];

            foreach (int num in nums)
            {
                if (sum < 0)
                {
                    sum = num;

                }
                else
                {
                    sum += num;
                }
                highest = Math.Max(highest, sum);
            }

            return highest;
        }
    }
}
