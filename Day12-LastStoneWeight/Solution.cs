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

            List<int> stoneList = stones.ToList();

            while (stoneList.Count > 1)
            {
                SmashStones(stoneList);
            }

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

            stones.Remove(second);
            stones.Remove(largest);

            if (second != largest)
            {
                stones.Add(largest - second);
            }

        }
    }
}
