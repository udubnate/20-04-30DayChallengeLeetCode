using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_Valid_Parenthesis_String
{
    public class Solution
    {

        public bool CheckValidString(string s)
        {
            // check for empty string
            if (s.Length == 0) { return false;  }

            int balance = 0;
            int ast_count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    balance -= 1;
                }
                else if(s[i] == ')')
                {
                    balance += 1;
                }
                else if(s[i] == '*')
                {
                    ast_count++;
                }
            }

            //asterisk gives you a balance negotiation 
            if (Math.Abs(balance) <= ast_count)
            {
                return true;
            } else
            {
                return false;
            }
            /*
            //check matching () return true, else false
            if (balance == 0)
            {
                return true;
            } else
            {
                return false;
            }
            */
        }
    }
}
