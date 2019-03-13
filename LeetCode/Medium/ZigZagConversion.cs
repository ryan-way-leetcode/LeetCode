using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium.ZigZagConversion
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;
            string retVal = string.Empty;
            for(int i = 0; i < numRows; i++)
            {
                int even = 2 * (numRows - 1) - 2*i;
                int odd = 2 * (numRows - 1) - even;
                int iterate = odd / 2;
                for(int count = 0; iterate < s.Length; count++)
                {
                    if ((count %2 == 0 && even != 0) || (count % 2 != 0 && odd != 0))
                    {
                        retVal += s[iterate];
                        iterate += count % 2 == 0 ? even : odd; 
                    }
                }
            }
            return retVal;
        }
    }
}
