using System;
using System.Collections.Generic;

namespace Day27_MaximalSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] M = new char[][] { 
                new char[] { '1','0','1','0','0'},
                new char[] { '1','0','1','1','1'},
                new char[] { '1','1','1','1','1'},
                new char[] { '1','0','0','1','0'}
            } ;
            Solution s = new Solution();
            int count = s.MaximalSquare(M);

            Console.WriteLine(count.ToString());
        }

        public class Solution
        {
            // https://www.youtube.com/watch?v=rMw2cnpmP-4
            // https://leetcode.com/problems/maximal-square/discuss/295672/C-DP

            public int MaximalSquare(char[][] matrix)
            {
                var n = matrix.Length;
                if (n == 0) return 0;
                var m = matrix[0].Length;

                var dp = new int[n, m];

                var global = 0;

                for (int i = 0; i < n; i++)
                {
                    dp[i, 0] = matrix[i][0] == '1' ? 1 : 0;
                    global = Math.Max(global, dp[i, 0]);
                }

                for (int j = 0; j < m; j++)
                {
                    dp[0, j] = matrix[0][j] == '1' ? 1 : 0;
                    global = Math.Max(global, dp[0, j]);
                }

                for (int i = 1; i < n; i++)
                {
                    for (int j = 1; j < m; j++)
                    {
                        if (matrix[i][j] == '1')
                        {
                            dp[i, j] = Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1])) + 1;
                            global = Math.Max(global, dp[i, j]);
                        }
                    }
                }

                return global * global;
            }
        }
        }

    }

