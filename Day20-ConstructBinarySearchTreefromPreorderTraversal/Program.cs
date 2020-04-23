using System;
using System.Reflection.Metadata.Ecma335;

namespace Day20_ConstructBinarySearchTreefromPreorderTraversal
{
    class Program
    {
        // accepted solution from here: https://leetcode.com/problems/construct-binary-search-tree-from-preorder-traversal/discuss/299527/C-code-easy-to-understand
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        // Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public class Solution
        {
            public TreeNode BstFromPreorder(int[] preorder)
            {
                if (preorder == null)
                    return null;
                // root node will always be first node in preorder traversal
                TreeNode root = new TreeNode(preorder[0]);

                // If we simply just insert all nodes in array 
                // using standard way of inserting node in BST it will give us original tree.

                for (int x = 1; x < preorder.Length; x++)
                    InsertInBST(root, preorder[x]);

                return root;
            }

            // standard BST insertion. 
            private void InsertInBST(TreeNode root, int val)
            {
                TreeNode current = root;
                TreeNode parent = null;
                while (current != null)
                {
                    parent = current;
                    current = current.val > val ? current.left : current.right;
                }

                if (parent.val > val)
                    parent.left = new TreeNode(val);
                else
                    parent.right = new TreeNode(val);
            }
        }
    }
}
