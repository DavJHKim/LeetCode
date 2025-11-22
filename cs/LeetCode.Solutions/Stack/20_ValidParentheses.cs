using System;
using System.Collections.Generic;

namespace LeetCode.Solutions;

public class ValidParenthesesSolutions
{
    public bool ValidParentheses(string s)
    {
        Stack<char> stack = new Stack<char>(); 
        Dictionary<char, char> dict = new Dictionary<char, char>()
        {
            { ')', '('},
            { '}', '{'},
            { ']', '['},
        };

        foreach (char c in s)
        {
            if (dict.ContainsKey(c))
                if (stack.Count > 0 && stack.Peek() == dict[c])
                    stack.Pop();
                else
                    return false;
            else
                stack.Push(c);
        } 
        return stack.Count == 0; 
    }
}
