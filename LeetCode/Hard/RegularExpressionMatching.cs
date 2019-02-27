using System;
using System.Collections.Generic;

namespace LeetCode.Hard.RegularExpressionMatching
{
    public class Solution
    {
        private bool characterMatch(char s, char p)
        {
            if (p == '.') return true;
            else return s == p;
        }

        public bool IsMatch(string s, string p)
        {
            //no star string matching
            int i = 0, j = 0;
            if (!p.Contains("*"))
            {
                if (s.Length != p.Length) return false;

                for(i = 0; i < s.Length; i++)
                {
                    if (!characterMatch(s[i], p[i])) return false;
                }
                return true;
            }

            for(; i < s.Length && j < p.Length; i++, j++)
            {
                if(j < p.Length-1 && p[j+1] == '*')
                {
                    string p_substring = p.Substring(j + 2);


                    for(; i <= s.Length; i++)
                    {
                        if (i < s.Length && !characterMatch(s[i],p[j])) return IsMatch(s.Substring(i), p_substring);
                        if (IsMatch(s.Substring(i), p_substring)) return true;
                    }
                    return false;

                }
                else
                {
                    if (!characterMatch(s[i], p[i])) return false;
                }
            }

            while(j != p.Length)
            {
                if ((p.Length - j) == 1) return false;
                else if ((p[j + 1] != '*')) return false;
                else j += 2;
            }
            return true;
        }
    }
}
