using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day15_ProductofArrayExceptSelf
{
    class Solution
    {

        // sourced from: https://leetcode.com/problems/product-of-array-except-self/discuss/118532/C-Solution after my own attempt didn't work

        public int[] ProductExceptSelf(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;

            int[] result = new int[nums.Length];
            int temp = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = temp;
                temp *= nums[i];
            }

            temp = 1;
            for (int i = result.Length - 1; i >= 0; i--)
            {
                result[i] *= temp;
                temp *= nums[i];
            }

            return result;
        }
    }
}
