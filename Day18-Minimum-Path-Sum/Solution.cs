using System;
using System.Collections.Generic;
using System.Text;

namespace Day18_Minimum_Path_Sum
{
    public class Solution
    {

        // took reference from here: https://leetcode.com/problems/minimum-path-sum/discuss/495431/Accepted-C-(DP)-solution%3A-Easy-to-understand-wcomments
        // I need to spend some more time with these graph and maze type problems, but wanted a working solution so I can be able to reference later

        public int MinPathSum(int[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
                return 0;
            int rows = grid.Length;
            int cols = grid[0].Length;

            // create dp structure
            int[][] dp = new int[rows][];
            for (int i = 0; i < rows; i++)
                dp[i] = new int[cols];

            // fill top-left corner
            dp[0][0] = grid[0][0];

            // fill 1st column
            for (int i = 1; i < rows; i++)
                dp[i][0] = dp[i - 1][0] + grid[i][0];

            // fill 1st row
            for (int i = 1; i < cols; i++)
                dp[0][i] = dp[0][i - 1] + grid[0][i];

            // calculate the minimum based on the minimum from top and left adjacent cells
            for (int i = 1; i < rows; i++)
                for (int j = 1; j < cols; j++)
                    dp[i][j] = grid[i][j] + Math.Min(dp[i - 1][j], dp[i][j - 1]);

            return dp[rows - 1][cols - 1];
        }

    }
}
