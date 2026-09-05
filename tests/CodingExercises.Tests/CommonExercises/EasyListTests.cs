using System;
using Xunit;
using CodingExercises.Shared;
using CodingExercises.CommonExercises.Easy_List;

namespace CodingExercises.Tests.CommonExercises;

public class ReverseListTests
{
    [Fact]
    public void TestReverseList()
    {
        var solver = new ReverseList();
        var head = new ListNode(1, new ListNode(2, new ListNode(3)));
        var rev = solver.Solution(head);
        Assert.Equal(3, rev.val);
        Assert.Equal(2, rev.next.val);
        Assert.Equal(1, rev.next.next.val);
    }
}

public class MergeTwoSortedListsTests
{
    [Fact]
    public void TestMerge()
    {
        var solver = new MergeTwoSortedLists();
        var l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var merged = solver.Solve(l1, l2);
        Assert.Equal(1, merged.val);
        Assert.Equal(1, merged.next.val);
        Assert.Equal(2, merged.next.next.val);
    }
}
