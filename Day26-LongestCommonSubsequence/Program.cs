using System;

namespace Day26_LongestCommonSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "abcde";
            string text2 = "ace";
            Solution s = new Solution();
            int count = s.LongestCommonSubsequence(text1, text2);
            
            Console.WriteLine("Output: " + count);
        }

        public class Solution
        {
            // dynamic programming matrix
            public int LongestCommonSubsequence(string text1, string text2)
            {
                //text 1 length
                int m = text1.Length;
                //text 2 length
                int n = text2.Length;

                int[,] L = new int[m + 1, n + 1];

                for (int i = 0; i <= m; i++)
                {
                    for (int j = 0; j <= n; j++)
                    {
                        // zero out first row and column - dynamic programming
                        if (i == 0 || j == 0)
                            L[i, j] = 0;
                        // if they match, then update current with adjacent + 1
                        else if (text1[i - 1] == text2[j - 1])
                            L[i, j] = L[i - 1, j - 1] + 1;
                        // if they don't match, Max of top and left
                        else
                            L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                    }
                }

                return L[m, n];
            }
        }
    }
}
