/*
 =======================================================================================
 CHALLENGE: Pythagoras (05-processing-data)
 CHAPTER: Chapter05_ProcessingData
 
 DESCRIPTION:
 * # Pythagoras
 *
 * Search the Internet for the Pythagorean theorem. It is a mathematical relation between the lengths of the sides of right hand triangles.
 *
 * The formula is:
 *
 *
 * The class `RightHandTriangle` defines three methods (`DetermineA()`, `DetermineB()` and `DetermineC()`) to calculate the different side length if the other two are given. Implement the formulas so the Unit tests pass.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter05_ProcessingData.Pythagoras.UnitTestRightHandTriangle
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter05_ProcessingData.Pythagoras
{
    public class RightHandTriangle
    {
        public double DetermineA(double b, double c)
        {
            // TODO: Calculate the a-side from the b- and c-side
            double a = 0;

            // Please dont change the code below (automatic unit tests)
            return a;
        }
        public double DetermineB(double a, double c)
        {
            // TODO: Calculate the b-side from the a- and c-side
            double b = 0;

            // Please dont change the code below (automatic unit tests)
            return b;
        }
        public double DetermineC(double a, double b)
        {
            // TODO: Calculate the c-side from the a- and b-side
            double c = 0;

            // Please dont change the code below (automatic unit tests)
            return c;
        }
    }
}
