from typing import List

def isAnagramSort(self, s: str, t: str) -> bool:
    ifuu len(s) != len(t):
        return False

    s_sorted = sorted(s)
    t_sorted = sorted(t)

    for i in range(len(s_sorted)): 
        if s_sorted[i] != t_sorted[i]:
            return False

    return True

def isAnagramHashMap(self, s: str, t: str) -> bool:
    if len(s) != len(t):
        return False

    countS, countT = {}, {}

    for i in range(len(s)):
        countS[s[i]] = 1 + countS.get(s[i], 0)
        countT[t[i]] = 1 + countT.get(t[i], 0)

    return countS == countT 
