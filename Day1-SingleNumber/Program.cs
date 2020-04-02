using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

namespace Day1_SingleNumber
{
    /*
     *  Given a non-empty array of integers, even element appears twice except one, find the single one
     */
    class Program
    {

        public static int SingleNumber(int[] nums)
        {
            var dict = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num] = (int)dict[num] + 1;
                }
                else
                {
                    dict.Add(num, 1);
                }        
            }

            foreach (var pair in dict)
            {
                if (pair.Value == 1)
                {
                    return pair.Key;
                }

            }
            return 0;
        }
        static void Main(string[] args)
        {
            int[] ints = new int[] { 1, 2, 2, 4, 4 };
            int[] ints2 = new int[] { 4, 2, 2, 4, 4, 7};

            int output =SingleNumber(ints2);

            Console.WriteLine(output);
        }
    }
}
