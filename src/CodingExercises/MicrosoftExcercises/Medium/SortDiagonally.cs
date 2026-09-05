/*
 =======================================================================================
 CHALLENGE: SortDiagonally
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the SortDiagonally problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.SortDiagonallyTests
 =======================================================================================
*/

using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class SortDiagonally
    {
        public int[][] DiagonalSort(int[][] mat)
        {
            var M = mat.Length;
            var N = mat[0].Length;

            var diagonals = new Dictionary<int, IList<int>>();

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    var currentDiagonal = GetDiagonal(i, j);

                    if (!diagonals.ContainsKey(currentDiagonal))
                    {
                        diagonals.Add(currentDiagonal, new List<int>());
                    }

                    diagonals[currentDiagonal].Add(mat[i][j]);
                }
            }

            foreach (var key in diagonals.Keys.ToList())
            {
                diagonals[key] = diagonals[key].OrderBy(val => val).ToList();
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    var currentDiagonal = GetDiagonal(i, j);

                    mat[i][j] = diagonals[currentDiagonal].First();

                    diagonals[currentDiagonal].Remove(mat[i][j]);
                }
            }

            return mat;
        }


        public int GetDiagonal(int row, int col)
        {
            return row - col;
        }
    }
}
