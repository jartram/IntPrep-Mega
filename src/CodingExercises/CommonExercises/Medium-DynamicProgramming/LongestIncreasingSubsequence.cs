/*
 =======================================================================================
 CHALLENGE: LongestIncreasingSubsequence
 CATEGORY: CommonExercises / Medium-DynamicProgramming
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LongestIncreasingSubsequence problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.LongestIncreasingSubsequenceTests
 =======================================================================================
*/

using System;

namespace CodingExercises.Exercises.DynamicProgramming
{
    public class LongestIncreasingSubsequence
    {
        // o(n2) time     o(n) space
        public int LengthOfLIS(int[] nums)
        {
            var LIS = new int[nums.Length];
            var max = 1;

            Array.Fill(LIS, 1);

            for (int i = 1; i < LIS.Length; i++) 
            {
                for (int j = 0; j < i; j++) 
                {
                    if (nums[i] > nums[j]) 
                    {
                        LIS[i]++;
                        max = Math.Max(max, LIS[i]);
                    }
                }
            }

            return max;
        }
    }
}
