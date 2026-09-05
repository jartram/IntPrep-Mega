/*
 =======================================================================================
 CHALLENGE: Point In Space (23-creating-and-using-objects)
 CHAPTER: Chapter23_CreatingAndUsingObjects
 
 DESCRIPTION:
 Create a 2D Point class with GetX, GetY, SetX, and SetY methods.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter23_CreatingAndUsingObjects.PointInSpace.UnitTestPoint
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter23_CreatingAndUsingObjects.PointInSpace;

public class Point
{
    private double x = 0;
    private double y = 0;

    public double GetX()
    {
        // TODO: Return X coordinate
        return x;
    }

    public double GetY()
    {
        // TODO: Return Y coordinate
        return y;
    }

    public void SetX(double x)
    {
        // TODO: Set X coordinate
        this.x = x;
    }

    public void SetY(double y)
    {
        // TODO: Set Y coordinate
        this.y = y;
    }
}
