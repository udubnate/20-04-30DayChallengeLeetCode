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
            Dictionary<int, int> impact = new Dictionary<int, int>();
            foreach (int num in arr)
            {
                if (impact.ContainsKey(num))
                {
                    impact[num] += 1;
                } else
                {
                    impact.Add(num, 1);
                }
            }
            int count = 0;

            int[] uniquearr = arr.Distinct().ToArray();

            for (int i = 0; i < uniquearr.Length - 1; i++)
            {
                if (uniquearr[i] == (uniquearr[i+1] - 1))
                {
                    if (impact[(uniquearr[i])] == impact[(uniquearr[i + 1])])
                    {
                        count += impact[(uniquearr[i])];
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
