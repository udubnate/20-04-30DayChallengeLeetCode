using System;

namespace Day9_BackspaceStringCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string str1 = "xywrrmp";
            string str2 = "xywrrmu#p";
            bool compare = s.BackspaceCompare(str1, str2);
            Console.WriteLine(compare.ToString());
        }
    }
}

