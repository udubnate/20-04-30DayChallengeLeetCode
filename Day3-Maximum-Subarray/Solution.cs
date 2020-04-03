using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Day3_Maximum_Subarray
{
    public class Solution
    {

        public int MaxSubArray(int[] nums)
        {
            int sum;
            int highest = int.MinValue;

            for (int i=0; i < nums.Length; i++)
            {
                sum = nums[i];
                
                highest = getHighest(sum, highest);

                for (int j=i+1; j < nums.Length; j++)
                {
                    sum += nums[j];
                    highest = getHighest(sum, highest);
                }

            }

            return highest;
        }

        int getHighest(int n, int m)
        {
            if (n > m)
            {
                return n;
            }  else
            {
                return m;
            }
        }
    }
}
