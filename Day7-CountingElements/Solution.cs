using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day7_CountingElements
{
    class Solution
    {
        public int CountElements(int[] arr)
        {
            Array.Sort(arr);
  
            int count = 0;
            int impact = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == (arr[i+1] - 1))
                {
                    count += 1 + impact;
                    impact = 0;
                
                }
                else if (arr[i] == arr[i + 1])
                {
                    impact++;
                } 
                else
                {
                    //reset impact if it is not the same, or greater-by 1
                    impact = 0;
                }

            }
            return count;
        }
    }
}
