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
            long input_digit = 1;
            while(input_digit <= input)
                input_digit *= 10;

            //list to reversed long
            long y = 0;
            int output_digit = 1;
            while (input_digit > 1)
            {
                y += (input%input_digit)/(input_digit/10) * output_digit;
                output_digit *= 10;
                input_digit /= 10;
            }

            //overflow handling
            if (y > int.MaxValue || y < int.MinValue) return 0;

            //return
            return (int)(negative? -y : y);
        }
    }
}
