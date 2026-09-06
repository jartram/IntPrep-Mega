/*
 =======================================================================================
 CHALLENGE: Total-surface (28-interfaces)
 CHAPTER: Chapter28_Interfaces
 
 DESCRIPTION:
 * # Total Surface
 *
 * Total Surface is a small part of an application build for an architect. The architect in question uses the app to calculate the total surface of a house when he/she visits a home that needs to be remodelled.
 *
 * The problem with the application is that it is not build with good programming practices in mind and is therefore hard to extend with new capabilities.
 *
 * Currently the application allows the user to enter two different room shape dimensions and can then determine the total surface area. Try the application before continuing with the assignment.
 *
 * To get a feel of the problems that arise when extending the application, add a new shape class `Rectangle` to the application that allows a rectangular surface to be added to the listing. Make sure the whole application is operational.
 *
 * While the `Main()` can probable be cleaned up a bit too, that is not the biggest problem of this application. The biggest problem lies within the fact that `AreaListing` is tightly coupled to the shape classes. This can be fixed using a decent interface.
 *
 * Do your best to fix this mess.
 *
 * ## Expected Output
 *
 * ```text
 * ....
 *
 * What shape would you like to create ?
 * 1. Circle
 * 2. Square
 * 0. Exit
 * 2
 * Please enter side of square: 33
 *
 * You current surface listing:
 * <Square> [side = 10]: 100 sq. meters
 * <Square> [side = 6.4]: 40.96000000000001 sq. meters
 * <Square> [side = 33]: 1089 sq. meters
 * <Circle> [radius = 12.2]: 467.59465056030473 sq. meters
 * <Circle> [radius = 2.15]: 14.522012041218819 sq. meters
 * ------------------------------
 * Total Area: 1712.0766626015236 sq. meters
 *
 * What shape would you like to create ?
 * 1. Circle
 * 2. Square
 * 0. Exit
 * 0
 * Thank you for using our app.
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter28_Interfaces.TotalSurfaceTest
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter28_Interfaces.Total_surface
{
    class Program
    {
        static int RequestAction() {
            int action = 0;
            do {
                Console.WriteLine("What shape would you like to create ?");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Square");
                Console.WriteLine("0. Exit");
                action = Convert.ToInt32(Console.ReadLine());
            } while (action < 0 || action > 2);

            return action;
        }

        static Circle CreateCircle() {
            Console.Write("Please enter radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(radius);
            return circle;
        }

        static Square CreateSquare() {
            Console.Write("Please enter side of square: ");
            double side = Convert.ToDouble(Console.ReadLine());
            Square square = new Square(side);
            return square;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Total Surface.");
            Console.WriteLine();

            AreaListing listing = new AreaListing();

            int action = 0;
            do {
                action = RequestAction();

                if (action == 1) {
                    Circle circle = CreateCircle();
                    listing.Add(circle);

                    Console.WriteLine();
                    Console.WriteLine("You current surface listing:");
                    Console.WriteLine(listing);
                    Console.WriteLine();
                } else if (action == 2) {
                    Square square = CreateSquare();
                    listing.Add(square);

                    Console.WriteLine();
                    Console.WriteLine("You current surface listing:");
                    Console.WriteLine(listing);
                    Console.WriteLine();
                } else {
                    Console.WriteLine("Thank you for using our app.");
                }

            } while (action != 0);

        }
    }
}
