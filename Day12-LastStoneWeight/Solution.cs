using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day12_LastStoneWeight
{
    public class Solution
    {
        public int LastStoneWeight(int[] stones)
        {
            //special case for stones = 1
            if (stones.Length == 1)
            {
                return stones[0];
            }

            List<int> stoneList = stones.OfType<int>().ToList();

            do
            {
                SmashStones(stoneList);
            }
            while (stoneList.Count > 1);

            // if stones are empty, return 0 otherwise return the remainder number
            if (stoneList.Count == 0)
            {
                return 0;
            }
            else
            {
                return stoneList[0];
            }
        }

        private void SmashStones(List<int> stones)
        {
            List<int> sortedStones = new List<int>(stones);
            sortedStones.Sort();
            int largest = sortedStones[sortedStones.Count - 1];
            int second = sortedStones[sortedStones.Count - 2];

            if (second == largest)
            {
                stones.Remove(second);
                stones.Remove(largest);
            }
            else
            {
                stones.Remove(second);
                int largeindex = stones.IndexOf(largest);
                stones[largeindex] = largest - second;
            }

        }
    }
}
