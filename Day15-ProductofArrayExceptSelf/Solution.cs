using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day15_ProductofArrayExceptSelf
{
    class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            List<int> outList = new List<int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                List<int> tempArray = new List<int>();
                tempArray = nums.ToList<int>();
                tempArray.RemoveAt(i);

                var product = tempArray.Aggregate((total, next) => total * next);
                outList.Add(product);
            }
            return outList.ToArray();
        }
    }
}
