/*
 =======================================================================================
 CHALLENGE: LongestCommonSubsequence
 CATEGORY: CommonExercises / Medium-DynamicProgramming
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LongestCommonSubsequence problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.LongestCommonSubsequenceTests
 =======================================================================================
*/

using System;

namespace CodingExercises.CommonExercises.Medium_DynamicProgramming
{
    public class LongestCommonSubsequence
    {
        public int Solve(string text1, string text2)
        {
            var m = text1.Length + 1;
            var n = text2.Length + 1;

            var dp = new int[m, n];

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (text1[i - 1] == text2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp[m - 1, n - 1];
        }
    }
}
