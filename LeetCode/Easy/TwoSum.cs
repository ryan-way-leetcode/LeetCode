using System;
using System.Collections.Generic;

namespace LeetCode.Easy.TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] retVal = new int[2];

            Dictionary<int, int> foundValues = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int value = nums[i];
                if (foundValues.ContainsKey(target - value))
                {
                    retVal[0] = foundValues[target - value];
                    retVal[1] = i;
                    return retVal;
                }
                else if (!foundValues.ContainsKey(value))
                {
                    foundValues.Add(value, i);
                }
            }

            return new int[] { };
        }
    }
}
