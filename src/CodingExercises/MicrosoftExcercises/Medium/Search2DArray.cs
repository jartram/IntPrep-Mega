/*
 =======================================================================================
 CHALLENGE: Search2DArray
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Search2DArray problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.Search2DArrayTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class Search2DArray
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var i = matrix.Length - 1;
            var j = 0;

            while (i >= 0 && j < matrix[i].Length)
            {
                var actual = matrix[i][j];

                if (actual == target)
                {
                    return true;
                }
                else if (actual > target)
                {
                    i--;
                }
                else
                {
                    j++;
                }
            }

            return false;
        }
    }
}
