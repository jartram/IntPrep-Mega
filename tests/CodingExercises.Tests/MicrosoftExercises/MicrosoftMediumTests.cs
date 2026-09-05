using System;
using Xunit;
using CodingExercises.MicrosoftExcercises.Medium;

namespace CodingExercises.Tests.MicrosoftExcercises;

public class LRUCacheTests
{
    [Fact]
    public void TestLRU()
    {
        var cache = new LRUCache(2);
        cache.Put(1, 1);
        cache.Put(2, 2);
        Assert.Equal(1, cache.Get(1));
        cache.Put(3, 3);
        Assert.Equal(-1, cache.Get(2));
    }
}

public class ReverseWordsTests
{
    [Fact]
    public void TestReverseWords()
    {
        var solver = new ReverseWords();
        Assert.Equal("blue is sky the", solver.Solve("the sky is blue"));
    }
}
