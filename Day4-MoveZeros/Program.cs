using System;

namespace Day3_MoveZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] nums = new int[]{0,1,0,3,12};
            //int[] nums = new int[]{0};
            //nt[] nums = new int[]{0,1};
            s.MoveZeroes(nums);

            Console.WriteLine(String.Join(',',nums));
        }
    }
}
