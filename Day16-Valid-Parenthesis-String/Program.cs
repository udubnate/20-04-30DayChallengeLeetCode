using System;
using System.Collections.Generic;

namespace Day16_Valid_Parenthesis_String
{
    class Program
    {
        static Dictionary<string, bool> testCases;

        static void Main(string[] args)
        {
            
            testCases = new Dictionary<string, bool>();
            //positive tests
            AddTest("()()");
            AddTest("((*)");
            AddTest("(*)*");
            AddTest("((()))");
            AddTest("(*))");
            //negative tests
            AddTest("(()");
            AddTest("");


            foreach (KeyValuePair<string,bool> kvp in testCases)
            {
                Console.WriteLine("Test: " + kvp.Key + ", Value = " + kvp.Value);
            }
        }

        static void AddTest(string str)
        {
            Solution s = new Solution();
            bool test1 = s.CheckValidString(str);
            testCases.Add(str, test1);
        }
    }
}
