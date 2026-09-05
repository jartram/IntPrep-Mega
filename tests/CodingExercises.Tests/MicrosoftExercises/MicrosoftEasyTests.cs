using System;
using System.Collections.Generic;
using Xunit;
using CodingExercises.MicrosoftExcercises.Easy;

namespace CodingExercises.Tests.MicrosoftExcercises;

public class ValidParenthesesTests
{
    [Fact]
    public void TestValidParentheses()
    {
        var solver = new ValidParentheses();
        Assert.True(solver.IsValid("()"));
        Assert.True(solver.IsValid("()[]{}"));
        Assert.False(solver.IsValid("(]"));
    }
}

public class RomanToIntegerTests
{
    [Fact]
    public void TestRomanToInt()
    {
        var solver = new RomanToInteger();
        Assert.Equal(3, solver.RomanToInt("III"));
        Assert.Equal(58, solver.RomanToInt("LVIII"));
        Assert.Equal(1994, solver.RomanToInt("MCMXCIV"));
    }
}

public class FizzBuzzTests
{
    [Fact]
    public void TestFizzBuzz()
    {
        var solver = new FizzBuzz();
        var result = solver.Solve(5);
        Assert.Equal(new string[] { "1", "2", "Fizz", "4", "Buzz" }, result);
    }
}
