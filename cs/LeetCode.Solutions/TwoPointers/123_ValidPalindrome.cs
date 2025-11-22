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
            if (Char.IsLetterOrDigit(s[l]) && Char.IsLetterOrDigit(s[r]))
            {
                if (l == r)
                {
                    return true;
                }
                else if (Char.ToLower(s[l]).Equals(Char.ToLower(s[r])))
                {
                    l++;
                    r--;
                }
                else
                {
                    return false;
                }
            }
            else if (Char.IsLetterOrDigit(s[l]))
            {
                r--; 
                continue;
            }
            else if (Char.IsLetterOrDigit(s[r]))
            {
                l++;
                continue;
            }
            else
            {
                l++;
                r--;
            }
        }
        return false;
    }
}
