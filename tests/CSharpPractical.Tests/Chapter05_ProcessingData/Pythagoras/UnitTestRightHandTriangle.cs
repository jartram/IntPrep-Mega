using System;
using Xunit;
using CSharpPractical.Chapter05_ProcessingData.Pythagoras;

namespace CSharpPractical.Tests.Chapter05_ProcessingData.Pythagoras;

public class UnitTestRightHandTriangle
    {
        RightHandTriangle uut = new RightHandTriangle();

        [Fact]
        public void TestASide()
        {
            Assert.Equal(3, uut.DetermineA(4, 5), 2);
        }

        [Fact]
        public void TestBSide()
        {
            Assert.Equal(3, uut.DetermineB(4, 5), 2);
        }

        [Fact]
        public void TestCSide()
        {
            Assert.Equal(5, uut.DetermineC(3, 4), 2);
        }
    }
