using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.RomanToInteger
{
    public class Solution
    {
        public int RomanCharToInt(char x)
        {
            switch (x)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    throw new Exception($"No supported conversion for this charcter: {x}");
            }
        }

        public int RomanToInt(string s)
        {
            int retValue = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(i < s.Length-1 && RomanCharToInt(s[i]) < RomanCharToInt(s[i + 1]))
                {
                    retValue += RomanCharToInt(s[i + 1]) - RomanCharToInt(s[i]);
                    i++;
                }
                else retValue += RomanCharToInt(s[i]);
            }
            return retValue;
        }
    }
}
