/*
 =======================================================================================
 CHALLENGE: CoordinatePlane (08-making-decisions)
 CHAPTER: Chapter08_MakingDecisions
 
 DESCRIPTION:
 * # Coordinate Plane
 *
 * Request both the `x` and `y` value of a point in 2D space from the user. Use the coordinates to determine in which quadrant the coordinates lie. This needs to be implemented in the `Point` class.
 *
 * Create a `Main` app that requests the coordinates from the user as shown below.
 *
 * Expected output:
 *
 * ```text
 * Welcome to the Coordinate Plane App
 *
 * Please enter the x-coordinate: 12.32
 * Please enter the y-coordinate: -74.2
 *
 * The point (12.32,-74.2) lies in the fourth quadrant.
 * ```
 *
 * Or when entering `(0,0)`:
 *
 * ```text
 * Welcome to the Coordinate Plane App
 *
 * Please enter the x-coordinate: 0
 * Please enter the y-coordinate: 0
 *
 * The point (0,0) lies in the origin.
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter08_MakingDecisions.CoordinatePlane.UnitTestPoint
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter08_MakingDecisions.CoordinatePlane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Coordinate Plane App");

            // TODO Request point coordinates from user

            // Create point
            Point point = new Point();
            point.X = 0;        // Set user value
            point.Y = 0;        // Set user value

            // TODO Output in which quadrant the point lies
            // Warning! Output different message if it lies in the origin
            string quadrant = point.Quadrant();

        }
    }
}
