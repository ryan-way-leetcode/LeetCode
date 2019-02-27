using System;
using System.Collections.Generic;

namespace LeetCode.Hard.MedianOfTwoSortedArrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int i_min = 0, i_max = nums1.Length - 1;
            int i = (i_min + i_max) / 2;
            int j = (nums1.Length + nums2.Length + 1) / 2 - i - 2;

            if(nums2.Length == 0)
            {
                if (nums1.Length % 2 == 0) return (nums1[i] + nums1[i + 1]) / 2;
                else return nums1[i];
            }
            else if(nums1.Length == 0)
            {
                if (nums2.Length % 2 == 0) return (nums2[i] + nums2[i + 1]) / 2;
                else return nums2[i];
            }

            while((j < nums2.Length - 1 && nums1[i] <= nums2[j+1]) && 
                (i < nums1.Length - 1 && nums2[j] <= nums1[i+1]))
            {
                if (j < nums2.Length - 1 && nums1[i] > nums2[j + 1])
                    i_max = i;
                else if (j < nums2.Length - 1 && nums2[j] < nums1[i + 1])
                    i_min = i;


                i = (i_min + i_max) / 2;
                j = (nums1.Length + nums2.Length + 1) / 2 - i - 2;
            }

            if ((nums1.Length + nums2.Length) % 2 == 0)
            {
                if(i < nums1.Length && j < nums2.Length)
                    return (nums1[i] + nums2[j]) / 2.0;
            }
            else
            {
                if (i < nums1.Length && j < nums2.Length)
                    return Math.Max(nums1[i], nums2[j]);
                else if (i >= nums1.Length && j < nums2.Length)
                    return nums2[j];
                else if (j >= nums2.Length && i < nums1.Length)
                    return nums1[i];
                else return 0;
            }

            return 0;
        }
    }
}
