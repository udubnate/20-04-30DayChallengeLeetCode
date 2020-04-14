using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_PerformStringShifts
{
    class Solution
    {

        // helper article: https://www.geeksforgeeks.org/left-rotation-right-rotation-string-2/

        public string StringShift(string s, int[][] shift)
        {
            foreach (int[] num in shift)
            {
                if (num[0] == 0)
                {
                    s = leftshift(s, num[1]);
                }
                else
                {
                    s = rightshift(s, num[1]);
                }
            }

            return s;
        }

        public string leftshift(string s, int d)
        {
            return (s.Substring(d, s.Length - d) + s.Substring(0, d));
        }

        public string rightshift(string s, int d)
        {
            return leftshift(s, s.Length - d);
        }
    }
}
