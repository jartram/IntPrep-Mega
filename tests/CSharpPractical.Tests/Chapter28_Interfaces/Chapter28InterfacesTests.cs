using System;
using Xunit;
using CSharpPractical.Chapter28_Interfaces.Generator_of_numbers;
using CSharpPractical.Chapter28_Interfaces.Total_surface;

namespace CSharpPractical.Tests.Chapter28_Interfaces;

public class GeneratorOfNumbersTest
{
    [Fact]
    public void TestNaturalGenerator()
    {
        IGenerator gen = new NaturalGenerator();
        Assert.Equal(0, gen.Next());
        Assert.Equal(1, gen.Next());
        Assert.Equal(2, gen.Next());
        gen.Reset();
        Assert.Equal(0, gen.Next());
    }

    [Fact]
    public void TestPowersOfTwoGenerator()
    {
        IGenerator gen = new PowersOfTwoGenerator();
        Assert.Equal(1, gen.Next());
        Assert.Equal(2, gen.Next());
        Assert.Equal(4, gen.Next());
        Assert.Equal(8, gen.Next());
        gen.Reset();
        Assert.Equal(1, gen.Next());
    }

    [Fact]
    public void TestFibonacciGenerator()
    {
        IGenerator gen = new FibonacciGenerator();
        Assert.Equal(1, gen.Next());
        Assert.Equal(1, gen.Next());
        Assert.Equal(2, gen.Next());
        Assert.Equal(3, gen.Next());
        Assert.Equal(5, gen.Next());
        Assert.Equal(8, gen.Next());
        gen.Reset();
        Assert.Equal(1, gen.Next());
    }
}

public class TotalSurfaceTest
{
    [Fact]
    public void TestTotalSurface()
    {
        var listing = new AreaListing();
        listing.Add(new Square(10));
        listing.Add(new Circle(12.2));
        Assert.True(listing.GetTotalArea() > 0);
    }
}
