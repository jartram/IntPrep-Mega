/*
 =======================================================================================
 CHALLENGE: StartToEnd (09-loops)
 CHAPTER: Chapter09_Loops
 
 DESCRIPTION:
 * # Start to End
 *
 * This C# application can make the sum of a series of numbers. Two `Sum` methods are available:
 *
 * * `Sum(int start, int end)` will make the sum of all the values between `start` (inclusive) and `end` (exclusive). Example: `Sum(1, 5)` will result in `1, 2, 3, 4` where the sum equals `10`.
 * * `Sum(int start, int step, int end)` will make the sum of all the values between `start` (inclusive) and `end` (exclusive) but the values will increment using the `step` value. Example: `Sum(1, 2, 8)` will result in `1, 3, 5, 7` where the sum equals `16`.
 *
 * Implement both methods inside the `Series` class.
 *
 * Can you explain what happens if:
 *
 * * you take a start value that is bigger than the end value?
 * * you take a negative step value?
 * * you take a step value of `0`
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter09_Loops.StartToEnd.UnitTestSeries
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter09_Loops.StartToEnd
{
    public class Series
    {
        public int Sum(int start, int end)
        {
            // TODO Determine sum of values between start (included) and end (excluded)
            int sum = 0;

            // Please dont change the code below (automatic unit tests)
            return sum;
        }

        public int Sum(int start, int step, int end)
        {
            // TODO Determine sum of values between start (included) and end (excluded)
            // Increment from start to end with a value of step
            int sum = 0;

            // Please dont change the code below (automatic unit tests)
            return sum;
        }
    }
}
