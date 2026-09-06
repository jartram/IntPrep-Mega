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

namespace CSharpPractical.Chapter26_Constructors.VectorFromStartToEnd
{
    public class VectorPath
    {
        public VectorPath()
        {
            // TODO: Initialize vector path
        }

        public void Add(Vector vector)
        {
            // TODO: Add vector to path
            throw new NotImplementedException();
        }

        public Vector ResultingVector()
        {
            // TODO: Calculate and return resulting net vector
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            // TODO: Return path description string
            throw new NotImplementedException();
        }
    }
}
