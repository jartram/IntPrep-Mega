using System;
using Xunit;
using CSharpPractical.Chapter04_StoringData.CsharpLand;

namespace CSharpPractical.Tests.Chapter04_StoringData.CsharpLand;

public class RollerCoasterTest
    {
        [Fact]
        public void TestMinimumHeight()
        {
            RollerCoaster coaster = new RollerCoaster();
            Assert.Equal(1.30, coaster.ShowMinimumHeight(), 2);
        }
    }
