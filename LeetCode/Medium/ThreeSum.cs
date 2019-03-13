using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium.ThreeSum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> retVal = new List<IList<int>>();
            if (nums.Length < 3) return retVal;
            Array.Sort(nums);
            HashSet<int> set = new HashSet<int>();
            foreach (var item in nums)
                set.Add(item);

            for (int i = 0; i < nums.Length-2; i++)
            {
                for (int j = i+1; j < nums.Length-1; j++)
                {
                    set.Remove(nums[i]);
                    set.Remove(nums[j]);
                    int minus_sum = -(nums[i] + nums[j]);
                    if(set.Contains(minus_sum) && minus_sum >= nums[j])
                    {
                        retVal.Add(new List<int>()
                        {
                            nums[i], nums[j], -(nums[i] + nums[j])
                        });
                    }
                    set.Add(nums[i]);
                    set.Add(nums[j]);
                    while (j < nums.Length - 2 && nums[j + 1] == nums[j]) j++;
                }
                while (i < nums.Length - 3 && nums[i + 1] == nums[i]) i++;
            }

            return retVal;
        }
    }
}
