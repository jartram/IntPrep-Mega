/*
 =======================================================================================
 CHALLENGE: Round About (23-creating-and-using-objects)
 CHAPTER: Chapter23_CreatingAndUsingObjects
 
 DESCRIPTION:
 Create a Circle class with radius, diameter, area, and circumference calculation.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter23_CreatingAndUsingObjects.RoundAbout.UnitTestCircle
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter23_CreatingAndUsingObjects.RoundAbout;

public class Circle
{
    private double radius = 0;

    public void SetRadius(double radius)
    {
        // TODO: Set radius (non-negative)
        this.radius = radius >= 0 ? radius : 0;
    }

    public double GetRadius()
    {
        // TODO: Return radius
        return radius;
    }

    public double GetDiameter()
    {
        // TODO: Return diameter (2 * radius)
        return radius * 2;
    }

    public double CalculateArea()
    {
        // TODO: Return PI * radius * radius
        throw new NotImplementedException();
    }

    public double CalculateCircumference()
    {
        // TODO: Return 2 * PI * radius
        throw new NotImplementedException();
    }
}
