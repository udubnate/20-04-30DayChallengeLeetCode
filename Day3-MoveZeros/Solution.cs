using System;

namespace Day3_MoveZeros
{

    /*
    *   Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    */
    class Solution
    {
        public void MoveZeroes(int[] nums)
        {

            int zerocount = 0 ;

            for (int i = 0; i < nums.Length - zerocount; i++)
            {
                if (nums[i] == 0){
                    //swap
                    IntSwap(ref nums[i], ref nums[nums.Length - zerocount - 1]);
                    zerocount++;
                }

            }
        }

        private void IntSwap(ref int a, ref int b){
            int temp = a;
            a = b;
            b = temp;
        }
    }

}
