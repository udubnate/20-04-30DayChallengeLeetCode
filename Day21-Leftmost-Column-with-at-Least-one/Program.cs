using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Day21_Leftmost_Column_with_at_Least_one
{
    // bit of help from Coding Channel: https://www.youtube.com/watch?v=40m4RIIqXW4
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Solution
    {
        public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix)
        {
            int rowcount = binaryMatrix.Dimensions()[0] - 1;
            int colcount = binaryMatrix.Dimensions()[1] - 1;
            int row = 0;
            int col = colcount;

            while (row <= rowcount && col >= 0)
            {
                if (binaryMatrix.Get(row,col) == 1)
                {
                    col--;
                } else
                {
                    row++;
                }
            }
            return col == colcount ? -1 : col + 1;
        }
    }

     class BinaryMatrix
    {
      public int Get(int x, int y) { return 0;  }
      public IList<int> Dimensions() { return new List<int>();  }
    }
}
