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

        List<int> _list;
        Dictionary<int, int> _dict;

        public FirstUnique(int[] nums)
        {
           _list = nums.ToList<int>();
            _dict = new Dictionary<int, int>();

            for (int i = 0; i < _list.Count; i++)
            {
                this.AddHash(_list[i]);
            }
        }

        public int ShowFirstUnique()
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (_dict[_list[i]] == 1)
                {
                    return _list[i];
                }
            }
            return -1;
        }

        public void Add(int value)
        {
            _list.Add(value);
            AddHash(value);

        }

        private void AddHash(int value)
        {
            if (_dict.ContainsKey(value))
            {
                _dict[value] += 1;
            }
            else
            {
                _dict.Add(value, 1);
            }
        }
    }
}
