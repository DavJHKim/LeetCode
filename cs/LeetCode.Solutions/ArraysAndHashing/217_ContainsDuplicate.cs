using System;

namespace LeetCode.Solutions;

public class ContainsDuplicateSolution 
{
    // Time complexity: O(n^2), Space Complexity: O(1)
    public bool ContainsDuplicate(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])      
                {
                    return true; 
                }
            }
        }
        return false;
    }

    public bool ContainsDuplicateHash(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();

        foreach (int num in nums)
        {
            if (seen.Contains(num)) 
            {
                return true;
            }
            seen.Add(num);
        }
        return false;
    }
}
