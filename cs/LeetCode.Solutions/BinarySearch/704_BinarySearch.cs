using System;

namespace LeetCode.Solutions;

public class BinarySearchSolutions
{
    public int BinarySearch(int[] nums, int target)
    {
        int n = nums.Length;
        int l = 0;
        int r = n - 1;

        while (l <= r)
        {
            int m = (((r - l) / 2) + l);
            if (nums[m] == target)
                return m;
            else if (nums[m] < target) 
                l = m + 1;
            else
                r = m - 1; 
        }
        return -1;
    }
}
