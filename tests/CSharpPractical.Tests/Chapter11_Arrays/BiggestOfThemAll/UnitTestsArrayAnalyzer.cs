using System;
using Xunit;
using CSharpPractical.Chapter11_Arrays.BiggestOfThemAll;

namespace CSharpPractical.Tests.Chapter11_Arrays.BiggestOfThemAll;

public class UnitTestsArrayAnalyzer
    {
        ArrayAnalyzer analyzer = new ArrayAnalyzer();

        [Fact]
        public void TestValueEmptyArray()
        {
            int[] values = { };
            Assert.Equal(0, analyzer.BiggestValue(values));
        }

        [Fact]
        public void TestIndexEmptyArray()
        {
            int[] values = { };
            Assert.Equal(-1, analyzer.BiggestIndex(values));
        }

        [Fact]
        public void TestValueSimpleSet()
        {
            int[] values = { 0, 1, 2, 3, 4, 5 };
            Assert.Equal(5, analyzer.BiggestValue(values));
        }

        [Fact]
        public void TestIndexSimpleSet()
        {
            int[] values = { 0, 1, 2, 3, 4, 5 };
            Assert.Equal(values.Length-1, analyzer.BiggestIndex(values));
        }

        [Fact]
        public void TestValueRandomSet()
        {
            Random generator = new Random();
            int[] values = new int[10];
            Assert.Equal(values.Max(), analyzer.BiggestValue(values));
        }

        [Fact]
        public void TestIndexRandomSet()
        {
            Random generator = new Random();
            int[] values = new int[10];
            int max = values.Max();
            Assert.Equal(Array.IndexOf(values, max), analyzer.BiggestIndex(values));
        }
    }
