using System;
using System.Collections.Generic;
using Xunit;
using LeetCode.Solutions;

namespace LeetCode.Tests;

public class ValidParenthesesTests 
{   
    private readonly ValidParenthesesSolutions _solution = new ValidParenthesesSolutions();

    [Fact]
    public void Test1()
    {
        string s = "[{()}]";

        bool result = _solution.ValidParentheses(s);
        Assert.True(result);
    }

    [Fact]
    public void WrongParentheses_False()
    {
        string s = "[(])";

        bool result = _solution.ValidParentheses(s);
        Assert.False(result);
    }
}
