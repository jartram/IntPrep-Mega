using System;
using Xunit;
using CodingExercises.CommonExercises.Easy_String;

namespace CodingExercises.Tests.CommonExercises;

public class ReverseStringTests
{
    [Fact]
    public void TestReverse()
    {
        var solver = new ReverseString();
        var s = new char[] { 'h', 'e', 'l', 'l', 'o' };
        solver.Reverse(s);
        Assert.Equal(new char[] { 'o', 'l', 'l', 'e', 'h' }, s);
    }
}

public class ReverseIntegerTests
{
    [Fact]
    public void TestReverseInt()
    {
        var solver = new ReverseInteger();
        Assert.Equal(321, solver.Reverse(123));
        Assert.Equal(-321, solver.Reverse(-123));
        Assert.Equal(21, solver.Reverse(120));
    }
}

public class FirstUniqueCharcsTests
{
    [Fact]
    public void TestFirstUnique()
    {
        var solver = new FirstUniqueCharcs();
        Assert.Equal(0, solver.FirstUniqChar("leetcode"));
        Assert.Equal(2, solver.FirstUniqChar("loveleetcode"));
    }
}

public class PalindromeTests
{
    [Fact]
    public void TestIsPalindrome()
    {
        var solver = new Palindrome();
        Assert.True(solver.IsPalindrome("A man, a plan, a canal: Panama"));
        Assert.False(solver.IsPalindrome("race a car"));
    }
}

public class LongestPrefixTests
{
    [Fact]
    public void TestLongestPrefix()
    {
        var solver = new LongestPrefix();
        Assert.Equal("fl", solver.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
        Assert.Equal("", solver.LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
    }
}
