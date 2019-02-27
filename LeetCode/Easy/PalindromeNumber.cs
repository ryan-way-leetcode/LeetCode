using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.PalindromeNumber
{
    public class Solution
    {
        //copied from reverse integer
        public int Reverse(int x)
        {
            int retValue = 0;
            while (x != 0)
            {
                if ((retValue * 10) / 10 != retValue) return 0;
                retValue *= 10;
                retValue += x % 10;
                x /= 10;
            }
            return retValue;
        }

        public bool IsPalindrome(int x)
        {
            //negative numbers should always result in false
            if (x < 0) return false;
            else return this.Reverse(x) == x;
        }
    }
}
