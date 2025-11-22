using System;
using LeetCode.Solutions;
using Xunit;

namespace LeetCode.Tests;

public class ValidPalindromeTests
{
    private readonly ValidPalindromeSolution _solution = new ValidPalindromeSolution();

    [Fact]
    public void Test1()
    {
        string s = "A man, a plan, a canal: Panama";

        bool result = _solution.ValidPalindrome(s);

        Assert.True(result);
    }
}
