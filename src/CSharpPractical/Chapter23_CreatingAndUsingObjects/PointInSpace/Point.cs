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

namespace CSharpPractical.Chapter23_CreatingAndUsingObjects.PointInSpace
{
    public class Point
    {
        private int x = 0;
        private int y = 0;

        public int GetX() => x;
        public void SetX(int value) => x = value;
        public int GetY() => y;
        public void SetY(int value) => y = value;

        public override string ToString() => $"[{x},{y}]";
    }
}
