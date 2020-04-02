using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_HappyNumber
{

    class Day2
    /*
    * A happy number is a number defined by the following process: Starting with any positive integer
    * , replace the number by the sum of the squares of its digits, and repeat the process until the number 
    * equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. 
    * Those numbers for which this process ends in 1 are happy numbers.
    */
    {
        //creating a seenbefore, to prevent endless loops
        private HashSet<int> seenBefore = new HashSet<int>();


        public bool IsHappy(int n)
        {
            //catch endless loops
            if (seenBefore.Contains(n))
            {
                return false;
            }
            seenBefore.Add(n);

            int result = 0;
            int[] ints = getIntArray(n);
            foreach (int num in ints)
            {
                result += square(num);
            }
            if (result == 1)
            {
                return true;
            }
            else
            {
                return IsHappy(result);
            }
        }

        public int square(int num)
        {
            return num * num;
        }

        public int[] getIntArray(int num)
        {
            List<int> ints = new List<int>();
            while (num > 0)
            {
                ints.Add(num % 10);
                num /= 10;
            }
            return ints.ToArray();
        }
    }


}
