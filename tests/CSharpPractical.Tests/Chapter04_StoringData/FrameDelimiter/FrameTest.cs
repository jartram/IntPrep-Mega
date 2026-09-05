using System;
using Xunit;
using CSharpPractical.Chapter04_StoringData.FrameDelimiter;

namespace CSharpPractical.Tests.Chapter04_StoringData.FrameDelimiter;

public class FrameTest
    {
        [Fact]
        public void TestStartDelimiter()
        {
            Frame frame = new Frame();
            Assert.Equal(0xAA, frame.StartOfFrame());
        }

        [Fact]
        public void TestEndDelimiter()
        {
            Frame frame = new Frame();
            Assert.Equal(0x55, frame.EndOfFrame());
        }
    }
