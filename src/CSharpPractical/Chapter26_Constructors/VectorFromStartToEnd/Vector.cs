/*
 =======================================================================================
 CHALLENGE: Vector (26-constructors)
 CHAPTER: Chapter26_Constructors
 
 DESCRIPTION:
 Implement a 2D Vector class with constructors, coordinate getters, magnitude calculation,
 and string representation.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter26_Constructors.VectorFromStartToEnd.VectorUnitTests
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter26_Constructors.VectorFromStartToEnd
{
    public class Vector
    {
        public Vector()
        {
            // TODO: Implement default constructor initializing (0, 0)
        }

        public Vector(double x, double y)
        {
            // TODO: Implement constructor initializing (x, y)
        }

        public double X()
        {
            // TODO: Return X coordinate
            throw new NotImplementedException();
        }

        public double Y()
        {
            // TODO: Return Y coordinate
            throw new NotImplementedException();
        }

        public double Magnitude()
        {
            // TODO: Return sqrt(x^2 + y^2)
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            // TODO: Return $"[{x};{y}] with magnitude {Magnitude()}"
            throw new NotImplementedException();
        }
    }
}
