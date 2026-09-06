using System;
using System.IO;
using Xunit;
using CSharpPractical.Chapter03_StartingInCsharp.BasicSyntaxError;
using JavaProg = CSharpPractical.Chapter03_StartingInCsharp.JavaProgrammer;
using NeedBreak = CSharpPractical.Chapter03_StartingInCsharp.NeedABreak;
using DevBy = CSharpPractical.Chapter03_StartingInCsharp.DevelopedBy;
using HW = CSharpPractical.Chapter03_StartingInCsharp.HelloWorld;
using PersDet = CSharpPractical.Chapter03_StartingInCsharp.PersonalDetails;

namespace CSharpPractical.Tests.Chapter03_StartingInCsharp;

public class BasicSyntaxErrorTest
{
    [Fact]
    public void TestBasicSyntaxErrorOutput()
    {
        var msg = Program.GetMessage();
        Assert.Equal("Nice, you just fixed the application.", msg);
    }
}

public class JavaProgrammerTest
{
    [Fact]
    public void TestJavaProgrammerOutput()
    {
        var msg = JavaProg.Program.GetMessage();
        Assert.Equal("I switched from Java to C# and this is my app.", msg);
    }
}

public class NeedABreakTest
{
    [Fact]
    public void TestNeedABreakOutput()
    {
        var lines = NeedBreak.Program.GetLines();
        Assert.NotNull(lines);
        Assert.Equal(2, lines.Length);
        Assert.Equal("One programmer said to another:", lines[0]);
        Assert.Equal("I need a </br>", lines[1]);
    }
}

public class DevelopedByTest
{
    [Fact]
    public void TestDevelopedByOutput()
    {
        var sw = new StringWriter();
        var orig = Console.Out;
        Console.SetOut(sw);
        try
        {
            DevBy.Program.Main(Array.Empty<string>());
            var output = sw.ToString();
            Assert.Contains("Hello and welcome", output, StringComparison.OrdinalIgnoreCase);
            Assert.Contains("developed by", output, StringComparison.OrdinalIgnoreCase);
        }
        finally
        {
            Console.SetOut(orig);
        }
    }
}

public class HelloWorldTest
{
    [Fact]
    public void TestHelloWorldOutput()
    {
        var sw = new StringWriter();
        var orig = Console.Out;
        Console.SetOut(sw);
        try
        {
            HW.Program.Main(Array.Empty<string>());
            var output = sw.ToString().Trim();
            Assert.Equal("Hello World", output);
        }
        finally
        {
            Console.SetOut(orig);
        }
    }
}

public class PersonalDetailsTest
{
    [Fact]
    public void TestPersonalDetailsOutput()
    {
        var sw = new StringWriter();
        var orig = Console.Out;
        Console.SetOut(sw);
        try
        {
            PersDet.Program.Main(Array.Empty<string>());
            var output = sw.ToString().Trim();
            Assert.False(string.IsNullOrWhiteSpace(output), "Expected personal details printed to terminal.");
        }
        finally
        {
            Console.SetOut(orig);
        }
    }
}
