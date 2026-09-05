using System;
using System.Collections.Generic;
using Xunit;
using CodingExercises.AmazonJourney.Medium;
using CE = CodingExercises.AmazonJourney;

namespace CodingExercises.Tests.AmazonJourney;

public class RobotBoundededTests
{
    [Fact]
    public void TestRobotBounded()
    {
        var solver = new RobotBounded();
        Assert.True(solver.IsRobotBounded("GGLLGG"));
        Assert.False(solver.IsRobotBounded("GG"));
        Assert.True(solver.IsRobotBounded("GL"));
    }
}

public class PriorityQueueTests
{
    [Fact]
    public void TestPQ()
    {
        var pq = new CE.PriorityQueue<int>(Comparer<int>.Default);
        Assert.Equal(0, pq.Count());
        Assert.True(pq.IsEmpty());
    }
}
