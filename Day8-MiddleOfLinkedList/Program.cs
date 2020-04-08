using System;

namespace Day8_MiddleOfLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Build Linked List from Input
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
            Solution s = new Solution();

            ListNode root = s.ArrayToLinkedList(nums);
            ListNode middle = s.MiddleNode(root);
            
            Console.WriteLine("Hello World!");
        }
    }
}
