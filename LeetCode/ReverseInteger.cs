using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseInteger
{
    public class Solution
    {
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
    }
}
