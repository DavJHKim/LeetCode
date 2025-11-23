using System;
using Xunit;
using LeetCode.Solutions;

namespace LeetCode.Tests;

public class BinarySearchTests
{
    private readonly BinarySearchSolutions _solution = new BinarySearchSolutions();

    [Fact]
    public void Test1()
    {
        int[] nums = new int[] {-1,0,3,5,9,12};
        int target = 9;
        int end = 4;

        int result = _solution.BinarySearch(nums, target);
        int result2 = Array.BinarySearch(nums, target);

        Assert.Equal(end, result);
        Assert.Equal(end, result2);
    }
}
