using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Day19_SearchInRotatedSortedArray
{
    // took from https://leetcode.com/problems/search-in-rotated-sorted-array/discuss/551715/C-practice-while-I-was-an-interviewer-on-March-25-2020
    // understand the binary search part need to go in more depth on how the rotation works
    class Program
    {

        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] nums = new int[] {0, 1, 2, 4, 5, 6, 7 };
            int target = 6;
            int output = s.Search(nums, target);
            Console.WriteLine("Output = " + output);
        }
    }

    public class Solution
    {
        public int Search(int[] numbers, int target)
        {
            if (numbers == null || numbers.Length == 0)
                return -1;

            var length = numbers.Length;
            int start = 0;
            int end = length - 1;
            while (start <= end)
            {
                var middle = start + (end - start) / 2;
                var middleValue = numbers[middle];

                if (middleValue == target)
                {
                    return middle;
                }

                var firstHalfAscending = middleValue >= numbers[start];
                if (firstHalfAscending)
                {   // in range 
                    if (target >= numbers[start] && target < middleValue)
                    {
                        // remove right half
                        end = middle - 1;
                    }
                    else
                    {
                        start = middle + 1;
                    }
                }
                else
                {
                    // in range 
                    if (target > middleValue && target <= numbers[end])
                    {
                        // remove left half
                        start = middle + 1;
                    }
                    else
                    {
                        end = middle - 1;
                    }
                }
            }

            return -1;
        }
    }
}
