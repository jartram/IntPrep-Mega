using System;
using Xunit;
using CodingExercises.CommonExercises.Easy_DynamicProgramming;

namespace CodingExercises.Tests.CommonExercises;

public class ClimbingStairsTests
{
    [Fact]
    public void TestClimbStairs()
    {
        var solver = new ClimbingStairs();
        Assert.Equal(2, solver.ClimbStairs(2));
        Assert.Equal(3, solver.ClimbStairs(3));
        Assert.Equal(5, solver.ClimbStairs(4));
    }
}

public class BuyAndSellStocksTests
{
    [Fact]
    public void TestMaxProfit()
    {
        var solver = new BuyAndSellStocks();
        Assert.Equal(5, solver.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
        Assert.Equal(4, solver.MaxProfit(new int[] { 1, 2, 3, 4, 5 }));
    }
}

public class HouseRobberTests
{
    [Fact]
    public void TestRob()
    {
        var solver = new HouseRobber();
        Assert.Equal(4, solver.Rob(new int[] { 1, 2, 3, 1 }));
        Assert.Equal(12, solver.Rob(new int[] { 2, 7, 9, 3, 1 }));
    }
}
