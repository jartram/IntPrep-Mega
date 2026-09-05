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
        private double x = 0;
        private double y = 0;

        public Vector()
        {
            x = 0;
            y = 0;
        }

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X() => x;
        public double Y() => y;
        public double Magnitude() => Math.Sqrt(x * x + y * y);

        public override string ToString() => $"[{x};{y}] with magnitude {Magnitude()}";
    }
}
