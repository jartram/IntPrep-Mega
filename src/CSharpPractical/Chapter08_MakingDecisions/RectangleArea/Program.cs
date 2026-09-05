/*
 =======================================================================================
 CHALLENGE: RectangleArea (08-making-decisions)
 CHAPTER: Chapter08_MakingDecisions
 
 DESCRIPTION:
 * # Rectangle Area
 *
 * The rectangle app allows you to calculate the area of a rectangle based on its `width` and `height`. Change the `Main` method to request both these floating-point values from the user.
 *
 * Next implement the `CalculateArea()` method inside of the class `Rectangle` to determine the area of the rectangle. However you should add a precaution to the code if either of the values is smaller than `0`. In that case return an `area` of `0`.
 *
 * Also adopt this strategy inside of `Main` at the bottom when the result is shown to the user. If either value was negative, output an appropriate message to the user.
 *
 * Example output with correct values:
 *
 * ```text
 * Welcome to the rectangle calculator
 *
 * Please enter width of rectangle: 3.2
 * Please enter height of rectangle: 5.0
 *
 * The area of a rectangle (3.2 by 5) = 16
 * ```
 *
 * Example output with negative values:
 *
 * ```text
 * Welcome to the rectangle calculator
 *
 * Please enter width of rectangle: -4.3
 * Please enter height of rectangle: 5
 *
 * Sorry, you provided negative value(s). Cannot determine area.
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter08_MakingDecisions.RectangleArea.UnitTestRectangle
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter08_MakingDecisions.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the rectangle calculator");

            // TODO Request the width of the rectangle from the user
            double width = 0;

            // TODO Request the height of the rectangle from the user
            double height = 0;

            // Calculate area
            Rectangle rectangle = new Rectangle();
            double area = rectangle.CalculateArea(width, height);

            // TODO Generate message to the user stating the area (show appropriate message if width or height was < 0)
            Console.WriteLine("\nPlease change this message");
        }
    }
}
