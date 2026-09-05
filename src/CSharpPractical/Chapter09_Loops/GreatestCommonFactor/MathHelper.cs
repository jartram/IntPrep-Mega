/*
 =======================================================================================
 CHALLENGE: GreatestCommonFactor (09-loops)
 CHAPTER: Chapter09_Loops
 
 DESCRIPTION:
 * # Greatest Common Factor
 *
 * Finish the application so it can determine the GCF (Greatest Common Factor) of two numbers. This is the highest number by which both numbers can be divided.
 *
 * The code needs to be implemented in the class `MathHelper`.
 *
 * Some tips:
 *
 * * Make sure to use the absolute values to determine the GCF.
 * * If either of the values is `0`, you can return the none-zero number or `0` if both are `0`.
 *
 * More info can also be found at [https://www.mathsisfun.com/greatest-common-factor.html](https://www.mathsisfun.com/greatest-common-factor.html).
 *
 * Example output:
 *
 * ```text
 * Welcome to the greatest common factor finder.
 *
 * Please input your first value: -24
 * Please input your second value: 16
 *
 * The greatest common factor of -24 and 16 is: 8
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter09_Loops.GreatestCommonFactor.UnitTestMathHelper
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter09_Loops.GreatestCommonFactor
{
    public class MathHelper
    {
        public int DetermineGreatestCommonFactor(int first, int second)
        {
            // TODO Determine the Greatest Common Factor
            int gcf = 0;

            // Please dont change the code below (automatic unit tests)
            return gcf;
        }
    }
}
