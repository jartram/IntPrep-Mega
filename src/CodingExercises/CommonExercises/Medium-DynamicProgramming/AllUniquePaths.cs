/*
 =======================================================================================
 CHALLENGE: AllUniquePaths
 CATEGORY: CommonExercises / Medium-DynamicProgramming
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the AllUniquePaths problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.AllUniquePathsTests
 =======================================================================================
*/

using System;
using System.Linq;

namespace CodingExercises.Exercises.DynamicProgramming
{
    public class AllUniquePaths
    {
        public int UniquePaths(int m, int n)
        {
            var matrix = new int[m, n];

            for (int i = 0; i < n; i++)
            {
                matrix[0, i] = 1;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
                    }
                }
            }

            return matrix[m - 1, n - 1];
        }
    }
}
