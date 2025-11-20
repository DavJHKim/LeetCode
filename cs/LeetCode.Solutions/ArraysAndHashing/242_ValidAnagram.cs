using System;
using System.Collections.Generic;

namespace LeetCode.Solutions;

public class ValidAnagramSolution
{
    public bool ValidAnagramSorting(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        char[] sCharArray = s.ToCharArray();
        char[] tCharArray = t.ToCharArray();

        Array.Sort(sCharArray);
        Array.Sort(tCharArray);

        string sCombined = new string(sCharArray);
        string tCombined = new string(tCharArray); 

        if (sCombined == tCombined)
        {
            return true;
        }
        return false;
    }
    
    public bool ValidAnagramHashMap(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> sDict = new Dictionary<char, int>();
        Dictionary<char, int> tDict = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (sDict.ContainsKey(s[i]))
            {
                sDict[s[i]]++;
            }
            else
            {
                sDict.Add(s[i], 1);
            }
            if (tDict.ContainsKey(t[i]))
            {
                tDict[t[i]]++;
            }
            else
            {
                tDict.Add(t[i], 1);
            }
        }

        if (tDict.Count != sDict.Count)
        {
            return false;
        }
        if (sDict.Except(tDict).Any())
        {
            return false;
        }
        return true;
    }
}
