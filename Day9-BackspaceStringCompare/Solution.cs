using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace Day9_BackspaceStringCompare
{

//Given two strings S and T, return if they are equal when both are typed into empty text editors. # means a backspace character.
    class Solution
    {
        public bool BackspaceCompare(string S, string T)
        {
            S = BacktickString(S);
            T= BacktickString(T);

            if (S == T)
            {
                return true;
            } else
            {
                return false;
            }
        }
     
    // find # in a String, and delete the # and the previous character.
    // if the first character, only delete #
    private string BacktickString(string s) 
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '#')
                {
                    if (i == 0)
                    {
                        s = s.Remove(i,1);
                        i--;
                    } 
                    else
                    {
                        s = s.Remove(i - 1, 2);
                        i -= 2;
                    }
                }
            }
            return s;
        }
    }
}
