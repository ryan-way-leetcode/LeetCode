using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            long input = x;
            //long to list
            bool negative = x < 0;
            input = Math.Abs(input);
            long divide = 1;
            List<long> list = new List<long>();
            while(divide <= input)
            {
                divide *= 10;
                list.Add((input % divide)/(divide/10));
            }
            
            //list to reversed long
            long y = 0;
            divide = 1;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                y += list[i] * divide;
                divide *= 10;
            }

            //overflow handling
            if (y > int.MaxValue || y < int.MinValue) return 0;

            //return
            return (int)(negative? -y : y);
        }
    }
}
