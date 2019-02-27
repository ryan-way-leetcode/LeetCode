using System;
using System.Collections.Generic;

namespace LeetCode.Easy.LongestCommonPrefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return string.Empty;
            if (strs.Length == 1) return strs[0];
            string curr_prefix = string.Empty;
            for(int i = 0; i < strs[0].Length; i++)
            {
                char evaluating_char = strs[0][i];
                foreach (var item in strs)
                {
                    if (i >= item.Length || item[i] != evaluating_char) return curr_prefix;
                }
                curr_prefix += evaluating_char;
            }
            return curr_prefix;
        }
    }
}
