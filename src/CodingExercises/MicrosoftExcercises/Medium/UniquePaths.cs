/*
 =======================================================================================
 CHALLENGE: UniquePaths
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the UniquePaths problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.UniquePathsTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class UniquePaths
    {
        public int Solve(int m, int n)
        {
            var dp = new int[m, n];

            for (int j = 0; j < n; j++)
            {
                dp[0, j] = 1;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0)
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                    }
                }
            }

            return dp[m - 1, n - 1];
        }
    }
}
