using System;
using Xunit;
using LeetCode.Solutions;

namespace LeetCode.Tests;

public class TwoSumTest
{
    private readonly TwoSumSolution _solution = new TwoSumSolution();

    [Fact]
    public void Test1()
    {
        int[] nums = [3, 4, 5, 6];
        int target = 7;
    
        int[] result = _solution.TwoSum(nums, target); 
        int[] resultHashMap = _solution.TwoSumHashMap(nums, target);

        Assert.Equal(new int[] { 0, 1 }, result);
        Assert.Equal(new int[] { 0, 1 }, resultHashMap);
    }

    [Fact]
    public void Test2()
    {
        int[] nums = [4, 5, 6];
        int target = 10;
    
        int[] result = _solution.TwoSum(nums, target); 
        int[] resultHashMap = _solution.TwoSumHashMap(nums, target);

        Assert.Equal(new int[] { 0, 2 }, result);
        Assert.Equal(new int[] { 0, 2 }, resultHashMap);
    }

    [Fact]
    public void Test3()
    {
        int[] nums = [5, 5];
        int target = 10;
    
        int[] result = _solution.TwoSum(nums, target); 
        int[] resultHashMap = _solution.TwoSumHashMap(nums, target);

        Assert.Equal(new int[] { 0, 1 }, result);
        Assert.Equal(new int[] { 0, 1 }, resultHashMap);
    }
}
