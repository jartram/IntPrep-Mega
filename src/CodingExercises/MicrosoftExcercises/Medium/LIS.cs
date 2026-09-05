/*
 =======================================================================================
 CHALLENGE: LIS
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LIS problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.LISTests
 =======================================================================================
*/

using System;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class LIS
    {
        public int LengthOfLIS(int[] nums)
        {
            var max = 1;
            var LIS = new int[nums.Length];

            Array.Fill(LIS, 1);

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        LIS[i] = Math.Max(LIS[i], LIS[j] + 1);
                        max = Math.Max(LIS[i], max);
                    }
                }
            }

            return max;
        }
    }
}
