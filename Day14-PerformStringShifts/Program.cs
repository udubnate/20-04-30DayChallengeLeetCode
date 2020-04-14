using System;

namespace Day14_PerformStringShifts
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            int[][] shift =
            {
                new int[] {1,1},
                new int[] {1,1},
                new int[] {0,2},
                new int[] {1,3}
            };
            string str = s.StringShift("abcdefg", shift);
            Console.WriteLine(str);
        }
    }
}
