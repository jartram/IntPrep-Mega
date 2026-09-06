/*
 =======================================================================================
 CHALLENGE: CanPartition
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the CanPartition problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.CanPartitionTests
 =======================================================================================
*/

﻿namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class CanPartition
    {
        public bool Solve(int[] nums)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private bool CanPartitionAux(int[] nums, int target)
        {
            var n = nums.Length;
            var m = target + 1;
            var dp = new bool[m];
            dp[0] = true;


            foreach (var num in nums)
            {
                for (int j = target; j >= num; j--)
                {
                    dp[j] = dp[j] || dp[j - num];
                }
            }

            return dp[m - 1];
        }
    }
}
