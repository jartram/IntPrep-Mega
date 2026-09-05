using System;
using Xunit;
using CSharpPractical.Chapter06_GettingUserData.The_metric_system;

namespace CSharpPractical.Tests.Chapter06_GettingUserData.The_metric_system;

public class TheMetricSystemTest
{
    [Fact]
    public void TestCentimetersToInches()
    {
        Assert.Equal(1.0, Program.CentimetersToInches(2.54), 2);
        Assert.Equal(10.0, Program.CentimetersToInches(25.4), 2);
    }

    [Fact]
    public void TestInchesToCentimeters()
    {
        Assert.Equal(2.54, Program.InchesToCentimeters(1.0), 2);
        Assert.Equal(25.4, Program.InchesToCentimeters(10.0), 2);
    }
}
