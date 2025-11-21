using System;

namespace LeetCode.Solutions;

public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {

            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    var found = new int[]{i, j};

                    return found;
                }
            }
        }
        return new int[0];
    }

    public int[] TwoSumHashMap(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int compliment = target - nums[i];

            if (dict.ContainsKey(compliment))
                return new int[] {dict[compliment], i};
            dict[nums[i]] = i;
        }
        return new int[0];
    }
}
