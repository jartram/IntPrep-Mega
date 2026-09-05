/*
 =======================================================================================
 CHALLENGE: ThirdRockFromTheSun (25-getters-setters-properties)
 CHAPTER: Chapter25_GettersSettersProperties
 
 DESCRIPTION:
 * # Third Rock from the Sun
 *
 * THe Earth has a surface area of about `510.1 million km`, where it's radius is about `6,371 km` [Wiki:Earth](https://en.wikipedia.org/wiki/Earth). We can easily check if this is correct.
 *
 * Create a new class called `Sphere` with a the following properties:
 *
 * * a property `Radius`;
 * * and a property `Diameter`.
 *
 * It's not wise to implement an attribute for both `radius` and `diameter`, because one depends on the other. A better idea is to have only one of these as an attribute and provide a property for the other that gets/set that same attribute.
 *
 * Also make sure that neither the diameter or the radius can be set to a negative value. You can take the absolute value of the incoming value.
 *
 * Next provide these methods for the class:
 *
 * * a method `Surface()` to calculate the surface of the sphere;
 * * a method `Volume()` to calculate the volume of the sphere;
 * * and a method `Circumference()` to calculate the circumference of the sphere.
 *
 * Implement a small demo application in `Main()` that displays the approximate calculated properties of the Earth (knowing it's not a perfect sphere) as shown below.
 *
 * ## Expected Output
 *
 * ```text
 * Third Rock from the Sun
 *
 * The Earth has a radius of 6371 km.
 * That means its diameter is about 12742 km.
 * It has a surface area of about 510064471 squared kilometers.
 * It's volume approximates 1.08321E+12 cubic kilometers.
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter25_GettersSettersProperties.ThirdRockFromTheSun.UnitTestSphere
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter25_GettersSettersProperties.ThirdRockFromTheSun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
