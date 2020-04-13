using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Day13_ContiguousArray
{

    //Given a binary array, find the maximum length of a contiguous subarray with equal number of 0 and 1.

    public class Solution
    {
        public int FindMaxLength(int[] nums)
        {
            List<int> intList = nums.ToList();

            int counter = 0;

            int maxvalue = 0;
            
            for (int i =0; i < intList.Count - 1; i++)
            {
                for (int j = i; j < intList.Count; j++)
                {
                    if (intList[j] == 0)
                    {
                        counter--;
                    }
                    else
                    {
                        counter++;
                    }

                    if (counter == 0)
                    {
                        maxvalue = Math.Max(maxvalue, j - i + 1);
                    }
                }

                counter = 0;
                  

            }

            return maxvalue;
        }
    }
}
