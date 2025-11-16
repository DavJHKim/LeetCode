using System;
using Xunit; 
using LeetCodeSolutions;

namespace LeetCodeTests;

public class ContainsDuplicateTests 
{
    private readonly ContainsDuplicateSolution _solution = new ContainsDuplicateSolution();

    [Fact]
    public void EmptyArray_ReturnsFalse()
    {
        // Arrange
        int[] nums = Array.Empty<int>();

        // Act
        bool result = _solution.ContainsDuplicate(nums);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void SingleElement_ReturnsFalse()
    {
        int[] nums = { 42 };

        bool result = _solution.ContainsDuplicate(nums);

        Assert.False(result);
    }

    [Fact]
    public void NoDuplicates_ReturnsFalse()
    {
        int[] nums = { 1, 2, 3, 4, 5 };

        bool result = _solution.ContainsDuplicate(nums);

        Assert.False(result);
    }

    [Fact]
    public void WithDuplicates_ReturnsTrue()
    {
        int[] nums = { 1, 2, 3, 1 };

        bool result = _solution.ContainsDuplicate(nums);

        Assert.True(result);
    }

    [Fact]
    public void WithMultipleDuplicates_ReturnsTrue()
    {
        int[] nums = { 2, 2, 3, 4, 4, 5 };

        bool result = _solution.ContainsDuplicate(nums);

        Assert.True(result);
    }

    [Fact]
    public void WithNegativeNumbersAndDuplicates_ReturnsTrue()
    {
        int[] nums = { -1, -2, -3, -1 };

        bool result = _solution.ContainsDuplicate(nums);

        Assert.True(result);
    }

    [Fact]
    public void WithLargeDistinctRange_ReturnsFalse()
    {
        int[] nums = new[] { int.MinValue, -1, 0, 1, int.MaxValue };

        bool result = _solution.ContainsDuplicate(nums);

        Assert.False(result);
    }
}
