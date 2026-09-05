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

namespace CSharpPractical.Chapter05_ProcessingData.Pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            RightHandTriangle triangle = new RightHandTriangle();

            // If you wish you can add some demo code here
        }
    }
}
