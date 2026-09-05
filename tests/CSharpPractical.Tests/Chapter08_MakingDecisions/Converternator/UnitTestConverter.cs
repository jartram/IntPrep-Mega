using System;
using Xunit;
using CSharpPractical.Chapter08_MakingDecisions.Converternator;

namespace CSharpPractical.Tests.Chapter08_MakingDecisions.Converternator;

public class UnitTestConverter
    {
        Converter converter = new Converter();

        [Fact]
        public void TestPoundToKilogram()
        {
            Assert.Equal(5.62, converter.PoundToKilogram(12.4), 2);
        }

        [Fact]
        public void TestKilogramToPound()
        {
            Assert.Equal(110.23, converter.KilogramToPound(50), 2);
        }

        [Fact]
        public void TestMileToKilometer()
        {
            Assert.Equal(197.95, converter.MileToKilometer(123), 2);
        }

        [Fact]
        public void TestKilometerToMile()
        {
            Assert.Equal(21.13, converter.KilometerToMile(34), 2);
        }
    }
