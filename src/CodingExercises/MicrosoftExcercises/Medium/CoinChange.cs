/*
 =======================================================================================
 CHALLENGE: CoinChange
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the CoinChange problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.CoinChangeTests
 =======================================================================================
*/

using System;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class CoinChange
    {
        public int Solve(int[] coins, int amount)
        {
            var dp = new int[amount + 1];

            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = amount + 1;
            }

            dp[0] = 0;

            foreach (var coin in coins)
            {
                for (int i = coin; i < dp.Length; i++)
                {
                    dp[i] = Math.Min(dp[i - coin] + 1, dp[i]);
                }
            }

            return dp[amount] == amount + 1 ? -1 : dp[dp.Length - 1];
        }
    }
}
