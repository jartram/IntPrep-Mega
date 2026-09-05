using System;
using Xunit;
using CSharpPractical.Chapter03_StartingInCsharp.BasicSyntaxError;
using JavaProg = CSharpPractical.Chapter03_StartingInCsharp.JavaProgrammer;
using NeedBreak = CSharpPractical.Chapter03_StartingInCsharp.NeedABreak;

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
