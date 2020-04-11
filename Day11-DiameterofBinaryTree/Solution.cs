using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_DiameterofBinaryTree
{
    public class Solution
    {
        // Still learning binary trees - had to get help on this one
        // Referenced: https://leetcode.com/problems/diameter-of-binary-tree/discuss/480836/Elementary-C-Solution

        int maxDiameter;

        public int DiameterOfBinaryTree(TreeNode root)
        {

            int res = 0;
            maxDepth(root, ref res);
            return Math.Max(0, res - 1);
        }

        private int maxDepth(TreeNode node, ref int max)
        {
            if (node == null)
            {
                return 0;
            }

            int leftLength = maxDepth(node.left, ref max);
            int rightLength = maxDepth(node.right, ref max);

            max = Math.Max(leftLength + rightLength + 1, max);
            return Math.Max(leftLength, rightLength) + 1;
        }
    }
}
