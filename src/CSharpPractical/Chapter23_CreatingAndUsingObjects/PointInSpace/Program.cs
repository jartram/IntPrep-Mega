/*
 =======================================================================================
 CHALLENGE: PointInSpace (23-creating-and-using-objects)
 CHAPTER: Chapter23_CreatingAndUsingObjects
 
 DESCRIPTION:
 * # Point In Space
 *
 * Create a new class called `Point` that follows the following UML class diagram:
 *
 * ```text
 * #################################
 * # Point
 * #################################
 * # - x: int
 * # - y: int
 * #################################
 * # + SetX(xValue: int): void
 * # + SetY(yValue: int): void
 * # + GetX(): int
 * # + GetY(): int
 * # + ToString(): string
 * #################################
 * ```
 *
 * Add two attributes to the class named `x` and `y`. These represent the coordinates of the `Point` in 2D-space.
 *
 * Also add methods to change both values and also to retrieve both values.
 *
 * Last, `override` the `ToString()` method so it returns the `Point` in the following format: `[13,12]` where the first coordinate is `x` and the second is `y`.
 *
 * Feel free to create a small demo app that creates a `Point` object, changes it's coordinates and outputs it state to the terminal.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter23_CreatingAndUsingObjects.PointInSpace.UnitTestPoint
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter23_CreatingAndUsingObjects.PointInSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write some code here");
        }
    }
}
