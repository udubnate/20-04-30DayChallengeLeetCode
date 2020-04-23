using Microsoft.VisualBasic.FileIO;
using System;

namespace Day23_BitwiseANDNumberRange
{
    //code got help from: https://leetcode.com/problems/bitwise-and-of-numbers-range/discuss/292348/C-beats-100-memory-usage-100-runtime-for-your-ref
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int output = s.RangeBitwiseAnd(5, 7);

            Console.WriteLine("Out: " + output);
        }
    }

    public class Solution
    {
        public int RangeBitwiseAnd(int m, int n)
        {
            int res = 0;
            while (m != n)
            {
                m >>= 1;
                n >>= 1;
                res++;
            }
            return m << res;
        }
    }
}
