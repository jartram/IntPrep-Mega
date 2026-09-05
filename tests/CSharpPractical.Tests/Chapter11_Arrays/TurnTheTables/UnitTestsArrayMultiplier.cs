using System;
using Xunit;
using CSharpPractical.Chapter11_Arrays.TurnTheTables;

namespace CSharpPractical.Tests.Chapter11_Arrays.TurnTheTables;

public class UnitTestsArrayMultiplier
    {
        ArrayMultiplier arrayMultiplier = new ArrayMultiplier();

        [Fact]
        public void TestNotNull()
        {
            int[] left = { 1 };
            int[] right = { 1 };
            Assert.NotNull(arrayMultiplier.Multiply(left, right));
        }

        [Fact]
        public void TestEasySet()
        {
            int multiplier = 5;
            int[] indices = { 0, 1, 2, 3, 4 };
            int[] multipliers = indices.Select(e => multiplier).ToArray<int>();
            int[] expected = indices.Select(e => e * multiplier).ToArray<int>();

            int[] results = arrayMultiplier.Multiply(indices, multipliers);
            Assert.Equal(expected, results);
        }

        [Fact]
        public void TestEmptyArray()
        {
            int multiplier = 5;
            int[] indices = { };
            int[] multipliers = indices.Select(e => multiplier).ToArray<int>();
            int[] expected = indices.Select(e => e * multiplier).ToArray<int>();

            int[] results = arrayMultiplier.Multiply(indices, multipliers);
            Assert.Equal(expected, results);
        }
    }
