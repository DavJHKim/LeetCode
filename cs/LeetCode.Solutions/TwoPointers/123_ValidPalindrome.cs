using System;

namespace LeetCode.Solutions;

public class ValidPalindromeSolution    
{   
    public bool ValidPalindrome(string s)
    {
        int n = s.Length;
        int l = 0;
        int r = n - 1; 

        while (l <= r)
        {
            while (l < r && !Char.IsLetterOrDigit(s[l]))
            {
                l++;
            }
            while (r > l && !Char.IsLetterOrDigit(s[r]))
            {
                r--;
            }
            if (!Char.ToLower(s[l]).Equals(Char.ToLower(s[r]))) 
            {
                return false;   
            }
            l++;
            r--;
        }
        return true;
    }
}
