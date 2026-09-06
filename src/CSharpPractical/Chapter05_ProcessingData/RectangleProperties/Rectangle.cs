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
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter05_ProcessingData.RectangleProperties
{
    public class Rectangle
    {
        double width = 3;
        double height = 8;

        public double CalculateArea()
        {
            // TODO: Calculate the area of a rectangle
            double area = 0;

            // Please dont change the code below (automatic unit tests)
            return area;
        }

        public double CalculateCircumference()
        {
            // TODO: Calculate the circumference of a rectangle
            double circumference = 0;

            // Please dont change the code below (automatic unit tests)
            return circumference;
        }

        public void PrintToTerminal()
        {
            // Print some info to the terminal
            Console.WriteLine("Rectangle: " + width + "cm by " + height + "cm");

            Console.WriteLine("The rectangle has an area of " + CalculateArea()
                + "sq centimeters.");

            Console.WriteLine("The rectangle has an circumference of " + CalculateCircumference()
                + " centimeters.");
        }
    }
}
