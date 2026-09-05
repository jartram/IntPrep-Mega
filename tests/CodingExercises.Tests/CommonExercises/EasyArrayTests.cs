using System;
using Xunit;
using CodingExercises.CommonExercises.Easy_Array;

namespace CodingExercises.Tests.CommonExercises;

public class TwoSumTests
{
    [Fact]
    public void TestBasicExample()
    {
        var solver = new TwoSum();
        var result = solver.GetTwoSum(new int[] { 2, 7, 11, 15 }, 9);
        Assert.NotNull(result);
        Array.Sort(result);
        Assert.Equal(new int[] { 0, 1 }, result);
    }

    [Fact]
    public void TestThreeElements()
    {
        var solver = new TwoSum();
        var result = solver.GetTwoSum(new int[] { 3, 2, 4 }, 6);
        Assert.NotNull(result);
        Array.Sort(result);
        Assert.Equal(new int[] { 1, 2 }, result);
    }
}

public class RotateArrayTests
{
    [Fact]
    public void TestRotate()
    {
        var solver = new RotateArray();
        var nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        solver.Rotate(nums, 3);
        Assert.Equal(new int[] { 5, 6, 7, 1, 2, 3, 4 }, nums);
    }
}

public class MoveZeroesTests
{
    [Fact]
    public void TestMoveZeroes()
    {
        var solver = new MoveZeroes();
        var nums = new int[] { 0, 1, 0, 3, 12 };
        solver.Move(nums);
        Assert.Equal(new int[] { 1, 3, 12, 0, 0 }, nums);
    }
}

public class RemoveDuplicatesFromSortedArrayTests
{
    [Fact]
    public void TestRemoveDuplicates()
    {
        var solver = new RemoveDuplicatesFromSortedArray();
        var nums = new int[] { 1, 1, 2 };
        int len = solver.RemoveDuplicates(nums);
        Assert.Equal(2, len);
        Assert.Equal(1, nums[0]);
        Assert.Equal(2, nums[1]);
    }
}

public class SingleNumberInArrayTests
{
    [Fact]
    public void TestSingleNumber()
    {
        var solver = new SingleNumberInArray();
        int res = solver.SingleNumber(new int[] { 4, 1, 2, 1, 2 });
        Assert.Equal(4, res);
    }
}

public class AddOneTests
{
    [Fact]
    public void TestAddOne()
    {
        var solver = new AddOne();
        var res = solver.PlusOne(new int[] { 1, 2, 3 });
        Assert.Equal(new int[] { 1, 2, 4 }, res);
    }
}
