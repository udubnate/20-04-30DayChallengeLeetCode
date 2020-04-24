using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Day23_LRUCache
{
    // managed hashtable alright but the capacity was throwing me off, I liked this list solution, linkedlist probably would have been better
    // https://leetcode.com/problems/lru-cache/discuss/594916/C-readable-solution-using-Dictionary-and-List
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 2;
            int key = 1;
            int value = 2;

            LRUCache obj = new LRUCache(capacity);
            int param_1 = obj.Get(key);
            obj.Put(key, value);
            Console.WriteLine("Hello World!");
        }
    }

    public class LRUCache
    {

        private Dictionary<int, int> _cache;
        private int _capacity;
        private int _currSize;
        private List<int> _recentlyUsedKeys;

        public LRUCache(int capacity)
        {
            _capacity = capacity;
            _currSize = 0;
            _cache = new Dictionary<int, int>();
            _recentlyUsedKeys = new List<int>();

        }

        public int Get(int key)
        {
            if (!_cache.ContainsKey(key))
            {
                return -1;
            }

            _recentlyUsedKeys.Remove(key);
            _recentlyUsedKeys.Add(key);
            return _cache[key];
            
        }

        public void Put(int key, int value)
        {
            if (_capacity == _currSize && !_cache.ContainsKey(key))
            {
                _currSize--;
                _cache.Remove(_recentlyUsedKeys[0]);
                _recentlyUsedKeys.RemoveAt(0);
            }

            if (!_cache.ContainsKey(key))
            {
                _currSize++;
            }
                _cache[key] = value;
                _recentlyUsedKeys.Remove(key);
                _recentlyUsedKeys.Add(key);
           
        }
    }

    /**
     * Your LRUCache object will be instantiated and called as such:
     * LRUCache obj = new LRUCache(capacity);
     * int param_1 = obj.Get(key);
     * obj.Put(key,value);
     */
}
