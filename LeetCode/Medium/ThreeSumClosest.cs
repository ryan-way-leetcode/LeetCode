using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium.ThreeSumClosest
{
    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int closest = target > 0? int.MinValue : int.MaxValue;
            for (int i = 0; i < nums.Length-2; i++)
            {
                for (int j = i+1; j < nums.Length-1; j++)
                {
                    for (int k = j+1; k < nums.Length; k++)
                    {
                        if(Math.Abs((long)nums[k]+nums[j]+nums[i] - (long)target) < Math.Abs((long)closest - (long)target))
                        {
                            closest = nums[k] + nums[j] + nums[i];
                        }
                    }
                }
            }
            return closest;
        }
    }
}
