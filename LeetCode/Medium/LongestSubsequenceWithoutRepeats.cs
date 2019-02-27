using System;
using System.Collections.Generic;

namespace LeetCode.Medium.LongestSubsequenceWithoutRepeats
{
    public class Solution
    {
        public const int NO_OF_CHARS = 256;
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;
            int max = 1;
            int[] visited = new int[256];
            for (int i = 0; i < visited.Length; i++)
                visited[i] = -1;

            int cur = 0;
            int start = 0;
            visited[s[cur]] = cur++;

            for (; cur < s.Length; cur++)
            {
                if (visited[s[cur]] >= start)
                {
                    start = visited[s[cur]] + 1;
                    if (max > (s.Length - cur + 1)) return max;
                }
                visited[s[cur]] = cur;
                max = Math.Max(max, cur - start + 1);
            }

            return max;
        }
    }
}
