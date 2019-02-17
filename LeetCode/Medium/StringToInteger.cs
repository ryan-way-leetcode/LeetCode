using System;
using System.Collections.Generic;
using System.Text;

namespace StringToInteger
{
    public class Solution
    {

        public int MyAtoi(string str)
        {
            int retValue = 0;
            bool negative = false;
            bool negativeSet = false;
            bool integerFound = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '+' || str[i] == '-')
                {
                    if (negativeSet) return 0;
                    negative = str[i] == '-';
                    negativeSet = true;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    if ((retValue * 10) / 10 != retValue) return negative? int.MinValue : int.MaxValue;
                    retValue *= 10;
                    if((retValue + (str[i] -'0')) - (str[i] -'0') != retValue) return negative ? int.MinValue : int.MaxValue;
                    retValue += str[i] - '0';
                    integerFound = true;
                }
                else if (str[i] == ' ')
                {
                    if (integerFound)
                    {
                        return negative ? -retValue : retValue;
                    }
                }
                else return negative ? -retValue : retValue;
            }

            return negative? -retValue : retValue;
        }
    }
}
