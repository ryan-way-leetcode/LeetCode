using System;
using System.Collections.Generic;

namespace LeetCode.Easy.ValidParentheses
{
    public class Solution
    {
        public bool IsClosing(char stack_char, char read_char)
        {
            switch (read_char)
            {
                case ']':
                    return stack_char == '[';
                case '}':
                    return stack_char == '{';
                case ')':
                    return stack_char == '(';
                default:
                    return false;
            }
        }

        public bool IsValid(string s)
        {
            Stack<char> parens = new Stack<char>();
            foreach (char c in s)
            {
                if (parens.Count == 0 || !IsClosing(parens.Peek(), c))
                    parens.Push(c);
                else parens.Pop();
            }
            return parens.Count == 0;
        }
    }
}
