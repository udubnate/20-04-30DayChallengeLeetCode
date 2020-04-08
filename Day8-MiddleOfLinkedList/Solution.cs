using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;
using System.Threading;

namespace Day8_MiddleOfLinkedList
{
    class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            int length = getLength(head);
            int middle = getMiddleSize(length);
            for (int i = 0; i < middle; i++)
            {
                head = head.next;
            }
            return head;
        }

        public ListNode Insert(ListNode root, int item)
        {
            ListNode temp = new ListNode(item);
            temp.next = root;
            root = temp;
            return root;
        }



        public int getLength(ListNode root)
        {
            int count = 1;
            while (root.next != null)
            {
                root = root.next;
                count++;
            }
            return count;
        }

        public int getMiddleSize(int length)
        {
            if (length % 2 == 0)
            {
                return length / 2;
            } else
            {
                return (length - 1) / 2;
            }
        }

        public ListNode ArrayToLinkedList(int[] arr)
        {
            ListNode root = null;

            for (int i = 0; i < arr.Length; i++)
            {
                root = this.Insert(root, arr[arr.Length - i - 1]);
            }
            return root;
        }
    }
}
