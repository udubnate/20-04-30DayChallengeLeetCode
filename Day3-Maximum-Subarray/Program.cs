using System;

namespace Day3_Maximum_Subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] ints = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //ints = new int[] { -1, -2, 2, 1, -5, 4 };
            ints = new int[] { -1, -2, 2, 1, -5};
            //int[] ints = new int[] { 7, 1, -3, 4, -1, 2, 1, -5, 4 };
            // ints = new int[] { 1 };
            // ints = new int[] { 0 };
            //ints = new int[] { -2, 1 };
            // ints = new int[] { -1 };
            int output = s.MaxSubArray(ints);
            Console.WriteLine(output.ToString());
        }
    }
}
