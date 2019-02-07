using System;
using System.Collections.Generic;
using System.Text;

namespace IntegerToRoman
{
    public class Solution
    {
        public string IntToRomanChar(int x, int offset)
        {
            switch (x)
            {
                case 3:
                case 2:
                case 1:
                case 0:
                    return new String(OffsetToPlaceToken(offset), x);
                case 4:
                    return new string(OffsetToPlaceToken(offset), 1) + new string(OffsetToPlaceToken(offset, true), 1);
                case 8:
                case 7:
                case 6:
                case 5:
                    return new string(OffsetToPlaceToken(offset, true), 1) + new string(OffsetToPlaceToken(offset), x - 5);
                case 9:
                    return new string(OffsetToPlaceToken(offset), 1) + new string(OffsetToPlaceToken(offset + 1), 1);
                default:
                    throw new Exception($"No supported conversion for this charcter: {x}");
            }
        }

        private char OffsetToPlaceToken(int offset, bool five = false)
        {
            switch (offset)
            {
                case 0:
                    return five ? 'V' : 'I';
                case 1:
                    return five ? 'L' : 'X';
                case 2:
                    return five ? 'D' : 'C';
                case 3:
                    return 'M';
                default:
                    throw new Exception("No supported conversions");
            }
        }

        public string IntToRoman(int num)
        {
            string retValue = string.Empty;
            int offset = 0;
            while (num != 0)
            {
                retValue = IntToRomanChar(num % 10, offset) + retValue;
                num /= 10;
                offset++;
            }
            return retValue;
        }
    }
}
