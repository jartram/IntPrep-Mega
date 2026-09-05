using System;
using Xunit;
using CSharpPractical.Chapter08_MakingDecisions.RectangleArea;

namespace CSharpPractical.Tests.Chapter08_MakingDecisions.RectangleArea;

public class UnitTestRectangle
    {
        Rectangle rectangle = new Rectangle();

        [Fact]
        public void TestPositiveValues()
        {
            Assert.Equal(150, rectangle.CalculateArea(10, 15), 2);
        }

        [Fact]
        public void TestNegativeValues()
        {
            Assert.Equal(0, rectangle.CalculateArea(-10, 15), 2);
            Assert.Equal(0, rectangle.CalculateArea(10, -15), 2);
            Assert.Equal(0, rectangle.CalculateArea(-10, -15), 2);
        }
    }
