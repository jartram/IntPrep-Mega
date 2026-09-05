/*
 =======================================================================================
 CHALLENGE: MinPathSum
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MinPathSum problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.MinPathSumTests
 =======================================================================================
*/

using System;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class MinPathSum
    {
        public int Solve(int[][] grid)
        {
            var dp = new int[grid[0].Length];

            Array.Fill(dp, int.MaxValue);

            dp[0] = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (j > 0)
                    {
                        dp[j] = Math.Min(dp[j], dp[j - 1]) + grid[i][j];
                    }
                    else
                    {
                        dp[j] = dp[j] + grid[i][j];
                    }
                }
            }

            return dp[dp.Length - 1];
        }
    }
}
