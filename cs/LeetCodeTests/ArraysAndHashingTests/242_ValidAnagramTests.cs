using System;
using Xunit;
using LeetCodeSolutions;

namespace LeetCodeTests;

public class ValidAnagramTests
{
    private readonly ValidAnagramSolution _solution = new ValidAnagramSolution();

    [Fact]
    public void SameLetters_ReturnsTrue()
    {
        bool result = _solution.ValidAnagramSorting("anagram", "nagaram");
        bool result2 = _solution.ValidAnagramHashMap("anagram", "nagaram");
        Assert.True(result);
        Assert.True(result2);
    }

    [Fact]
    public void DifferentLetters_ReturnsFalse()
    {
        bool result = _solution.ValidAnagramSorting("rat", "car");
        bool result2 = _solution.ValidAnagramHashMap("rat", "car");
        Assert.False(result);
        Assert.False(result2);
    }

    [Fact]
    public void BothEmptyStrings_ReturnsTrue()
    {
        bool result = _solution.ValidAnagramSorting("", "");
        Assert.True(result);
    }

    [Fact]
    public void SameCharactersDifferentFrequencies_ReturnsFalse()
    {
        bool result = _solution.ValidAnagramSorting("aacc", "ccac");
        Assert.False(result);
    }

    [Fact]
    public void UnicodeCharacters_ReturnsTrue()
    {
        bool result = _solution.ValidAnagramSorting("áßç", "ßçá");
        Assert.True(result);
    }

    [Fact]
    public void UnicodeCharactersDifferent_ReturnsFalse()
    {
        bool result = _solution.ValidAnagramSorting("áßç", "áßc");
        Assert.False(result);
    }

    [Fact]
    public void CaseSensitiveCheck_ReturnsFalse()
    {
        bool result = _solution.ValidAnagramSorting("Listen", "silent");
        Assert.False(result); // capital 'L' makes it different
    }

    [Fact]
    public void LongStringsCorrect_ReturnsTrue()
    {
        bool result = _solution.ValidAnagramSorting("aabbccddeeffgg", "gfeeddccbbaag");
        Assert.False(result);
    }

    [Fact]
    public void LongStringsIncorrect_ReturnsFalse()
    {
        bool result = _solution.ValidAnagramSorting("aabbccddeeffgg", "gfeeddccbbaagx");
        Assert.False(result);
    }
}
