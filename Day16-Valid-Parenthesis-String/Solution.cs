using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_Valid_Parenthesis_String
{
    public class Solution
    {

        //referenced this code: https://leetcode.com/problems/valid-parenthesis-string/discuss/280760/C-simple-Solution

        public bool CheckValidString(string s)
        {
            // check for empty string
            if (s.Length == 0) { return true;  }

            int left = 0;
            int any = 0;
            int needsright = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    left++;
                    needsright++;
                }
                else if (s[i] == '*')
                {
                    any++;
                    if (needsright > 0)
                    {
                        needsright--;
                    }
                }
                else if(s[i] == ')')
                {
                    if (left > 0)
                    {
                        left--;
                        if (needsright > 0)
                        {
                            needsright--;
                        }
                    }
                    else if (any > 0) any--;
                    else return false;
                    
                }
                
                
            }
            return needsright == 0;
        }
    }
}
