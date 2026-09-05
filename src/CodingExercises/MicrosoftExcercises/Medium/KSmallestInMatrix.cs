/*
 =======================================================================================
 CHALLENGE: KSmallestInMatrix
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the KSmallestInMatrix problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.KSmallestInMatrixTests
 =======================================================================================
*/

using System;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class KSmallestInMatrix
    {
        // Kinda shitty sol
        public int KthSmallest(int[][] matrix, int k)
        {
            var sorted = new int[matrix.Length * matrix[0].Length];
            var sortedIndex = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    sorted[sortedIndex++] = matrix[i][j];
                }
            }

            Array.Sort(sorted);

            return sorted[k - 1];
        }
    }
}
