using System;
using System.Collections.Generic;
using System.Text;

namespace Day17_NumberOfIslands
{
    // completely ripped off: https://leetcode.com/problems/number-of-islands/discuss/294326/C-DFS ( need to add DFS to my learning list)

    public class Solution
    {
        int n = 0;
        int m = 0;
        public int NumIslands(char[][] grid)
        {
            n = grid.Length;
            if (n == 0) return 0;
            m = grid[0].Length;

            var isVisited = new bool[n, m];

            var count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (!isVisited[i, j] && grid[i][j] == '1')
                    {
                        DFS(grid, i, j, isVisited);
                        count++;
                    }
                }
            }

            return count;
        }

        private void DFS(char[][] grid, int x, int y, bool[,] isVisited)
        {
            if (x >= n || x < 0 || y >= m || y < 0)
            {
                return;
            }

            if (isVisited[x, y]) return;
            if (grid[x][y] == '0') return;

            isVisited[x, y] = true;

            var directions = new (int, int)[] { (0, 1), (0, -1), (1, 0), (-1, 0) };

            foreach (var direction in directions)
            {
                var nextX = x + direction.Item1;
                var nextY = y + direction.Item2;

                DFS(grid, nextX, nextY, isVisited);
            }
        }
    }

}
