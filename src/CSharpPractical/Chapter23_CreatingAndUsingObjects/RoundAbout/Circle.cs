/*
 =======================================================================================
 CHALLENGE: Round About (23-creating-and-using-objects)
 CHAPTER: Chapter23_CreatingAndUsingObjects
 
 DESCRIPTION:
 Create a Circle class with radius, diameter, area, and circumference calculation.
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter23_CreatingAndUsingObjects.RoundAbout.UnitTestCircle
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter23_CreatingAndUsingObjects.RoundAbout
{
    public class Circle
    {
        private double radius = 0;

        public void SetRadius(double r)
        {
            if (r >= 0) radius = r;
        }

        public double GetRadius() => radius;
        public double GetDiameter() => 2 * radius;
        public double CalculateArea() => Math.PI * radius * radius;
        public double CalculateCircumference() => 2 * Math.PI * radius;
    }
}
