/*
 =======================================================================================
 CHALLENGE: VectorPath (26-constructors)
 CHAPTER: Chapter26_Constructors
 
 DESCRIPTION:
 Implement a VectorPath class that tracks a sequence of 2D Vectors and calculates the
 net resulting vector (sum of all vectors).
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter26_Constructors.VectorFromStartToEnd.VectorPathUnitTests
 =======================================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPractical.Chapter26_Constructors.VectorFromStartToEnd
{
    public class VectorPath
    {
        private List<Vector> vectors = new List<Vector>();

        public void Add(Vector v)
        {
            vectors.Add(v);
        }

        public Vector ResultingVector()
        {
            return new Vector(vectors.Sum(v => v.X()), vectors.Sum(v => v.Y()));
        }

        public override string ToString()
        {
            return string.Join("\n", vectors.Select(v => v.ToString()));
        }
    }
}
