using System;
using Xunit;

namespace CodingExercises.Tests.AmazonJourney;

public class ConcatenatedWordsTests
{
    [Fact]
    public void TestCompilationAndType()
    {
        Assert.NotNull(typeof(CodingExercises.AmazonJourney.Hard.Solution));
    }
}

public class DijsktraTests
{
    [Fact]
    public void TestCompilationAndType()
    {
        Assert.NotNull(typeof(CodingExercises.AmazonJourney.Medium.Solution));
    }
}
