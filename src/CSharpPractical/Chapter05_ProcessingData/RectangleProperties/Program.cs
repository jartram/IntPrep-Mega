/*
 =======================================================================================
 CHALLENGE: RectangleProperties (05-processing-data)
 CHAPTER: Chapter05_ProcessingData
 
 DESCRIPTION:
 * # Rectangle Properties
 *
 * This application was build to determine the `area` and `circumference` of a rectangle. However the previous student programming this app forgot the formulas for both.
 *
 * Both calculations need to be implemented in the methods `CalculateArea` and `CalculateCircumference` in the file `RectangleProperties\Rectangle.cs`.
 *
 * Expected output:
 *
 * ```text
 * Rectangle: 3cm by 8cm
 * The rectangle has an area of 24sq centimeters.
 * The rectangle has an circumference of 22 centimeters.
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter05_ProcessingData.RectangleProperties.UnitTestRectangle
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter05_ProcessingData.RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.PrintToTerminal();
        }
    }
}
