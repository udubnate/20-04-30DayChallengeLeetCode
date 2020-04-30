using System;

namespace CheckValidSequenceInTreeRootToLeaf
{

    // completely took this solution: https://github.com/tanaychaulinsec/30-day-leetcoding-challenge/blob/master/CheckValidSequenceInTreeRootToLeaf.py
    // will learn more about it later in the youtube https://www.youtube.com/watch?v=u-fOQVTKBfg
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    
 // Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }

    public class Solution
    {
        public bool IsValidSequence(TreeNode root, int[] arr)
        {

            return dfs(root, arr, 0);
        }

        bool dfs(TreeNode root, int[] arr, int index)
        {
            int n = arr.Length;
            if (root == null || index == n || arr[index] != root.val)
            {
                return false;
            }
            if (index == n-1 && !(root.left != null || root.right != null))
            {
                return true;
            }
            return (dfs(root.left, arr, index + 1) || dfs(root.right, arr, index + 1));
        }
    }
}
