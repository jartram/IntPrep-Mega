using System;
using System.IO;
using Xunit;
using CSharpPractical.Chapter07_Methods.HailCSharp;
using CSharpPractical.Chapter07_Methods.HelloMisterRoboto;
using CSharpPractical.Chapter07_Methods.LaResistance;
using CSharpPractical.Chapter07_Methods.SumAndDifference;
using CSharpPractical.Chapter07_Methods.TossADieToYourWitcher;

namespace CSharpPractical.Tests.Chapter07_Methods;

public class Chapter07MethodsTests
{
    [Fact]
    public void TestHailCSharp()
    {
        var sw = new StringWriter();
        var orig = Console.Out;
        Console.SetOut(sw);
        try
        {
            CSharpPractical.Chapter07_Methods.HailCSharp.Program.HailCSharp();
            var output = sw.ToString();
            Assert.Contains("starter language", output);
        }
        finally
        {
            Console.SetOut(orig);
        }
    }

    [Fact]
    public void TestHelloMisterRoboto()
    {
        var sw = new StringWriter();
        var orig = Console.Out;
        Console.SetOut(sw);
        try
        {
            CSharpPractical.Chapter07_Methods.HelloMisterRoboto.Program.GreetTheUser();
            var output = sw.ToString();
            Assert.Contains("Hello, I am Mister Roboto", output);
        }
        finally
        {
            Console.SetOut(orig);
        }
    }

    [Fact]
    public void TestLaResistance()
    {
        double series = CSharpPractical.Chapter07_Methods.LaResistance.Program.SolveSeries(120, 200);
        Assert.Equal(320, series);

        double parallel = CSharpPractical.Chapter07_Methods.LaResistance.Program.SolveParallel(120, 200);
        Assert.Equal(75, parallel);
    }

    [Fact]
    public void TestSumAndDifference()
    {
        int sum = CSharpPractical.Chapter07_Methods.SumAndDifference.Program.Add(24, 16);
        Assert.Equal(40, sum);

        int diff = CSharpPractical.Chapter07_Methods.SumAndDifference.Program.Subtract(24, 16);
        Assert.Equal(8, diff);
    }

    [Fact]
    public void TestTossADieToYourWitcher()
    {
        for (int i = 0; i < 50; i++)
        {
            int val = CSharpPractical.Chapter07_Methods.TossADieToYourWitcher.Program.ThrowDie();
            Assert.InRange(val, 1, 6);
        }
    }
}
