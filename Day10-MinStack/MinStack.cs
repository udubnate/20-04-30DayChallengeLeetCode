using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day10_MinStack
{
    public class MinStack
    {
        private List<int> arr = new List<int>();

        /** initialize your data structure here. */
        public MinStack()
        {

        }

        public void Push(int x)
        {
            arr.Add(x);
        }

        public void Pop()
        {
            arr.RemoveAt(arr.Count-1);
        }

        public int Top()
        {
            return arr[arr.Count-1];
        }

        public int GetMin()
        {
            return arr.Min();
        }
    }

}
