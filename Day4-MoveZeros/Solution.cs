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
            int nonzero = 0;
            int zero = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0){
                    nums[nonzero] = nums[i];
                    nonzero++;
                } else {
                    zero++;
                }
            }
            //append zeros to end
            for (int i = 0; i < zero; i++){
                nums[nums.Length-1-i] = 0;
            }
        }
    }

}
