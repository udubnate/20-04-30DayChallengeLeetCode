using System;
using System.Collections.Generic;
using System.Linq;

namespace Day28_FirstUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            FirstUnique firstUnique = new FirstUnique(new int[] { 2, 3, 5 });
            int out1 = firstUnique.ShowFirstUnique(); // return 2
            firstUnique.Add(5);            // the queue is now [2,3,5,5]
            int out2 = firstUnique.ShowFirstUnique(); // return 2
            firstUnique.Add(2);            // the queue is now [2,3,5,5,2]
            int out3 = firstUnique.ShowFirstUnique(); // return 3
            firstUnique.Add(3);            // the queue is now [2,3,5,5,2,3]
            int out4 = firstUnique.ShowFirstUnique(); // return -1

            Console.WriteLine("Hello World!");
        }
    }

    public class FirstUnique
    {

        Queue<int> _queue;
        Dictionary<int, int> _dict;

        public FirstUnique(int[] nums)
        {

            _dict = new Dictionary<int, int>();
            _queue = new Queue<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (_dict.ContainsKey(nums[i])){
                    _dict[nums[i]] += 1;
                } else
                {
                    _dict.Add(nums[i], 1);
                }
                _queue.Enqueue(nums[i]);

            }
        }

        public int ShowFirstUnique()
        {
           while (_queue.Count != 0 && _dict[_queue.Peek()] > 1)
            {
                _queue.Dequeue();
            }
           if (_queue.Count == 0)
            {
                return -1;
            }
            return _queue.Peek();
            
        }

        public void Add(int value)
        {
            if (_dict.ContainsKey(value))
            {
                _dict[value] += 1;
            }
            else
            {
                _dict.Add(value, 1);
            }
            _queue.Enqueue(value);
        }

     
    }
}
