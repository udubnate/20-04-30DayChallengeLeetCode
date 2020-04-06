using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace Day6_GroupAnagrams
{
    class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            //check if item exists
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();


            for (int i=0; i < strs.Length; i++)
            {
                //sort string
                string sortedstring = String.Concat(strs[i].OrderBy(c => c));

                if (!(dict.ContainsKey(sortedstring)))
                {
                    dict.Add(sortedstring, new List<string>());
                } 
                dict[sortedstring].Add(strs[i]);
            }
            List<IList<String>> results = new List<IList<String>>(dict.Values);

            return results;
        }
    }
}
