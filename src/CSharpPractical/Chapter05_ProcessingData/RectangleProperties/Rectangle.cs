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
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter05_ProcessingData.RectangleProperties.UnitTestRectangle
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter05_ProcessingData.RectangleProperties
{
    public class Rectangle
    {
        private double width = 12.3;
        private double height = 4.5;

        public double CalculateArea()
        {
            return width * height;
        }

        public double CalculateCircumference()
        {
            return 2 * (width + height);
        }
            public void PrintToTerminal() { }
}
}
