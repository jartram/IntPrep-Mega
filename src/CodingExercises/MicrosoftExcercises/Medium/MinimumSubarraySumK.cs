/*
 =======================================================================================
 CHALLENGE: MinimumSubarraySumK
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MinimumSubarraySumK problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.MinimumSubarraySumKTests
 =======================================================================================
*/

using System;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class MinimumSubarraySumK
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            var min = int.MaxValue;
            var sum = 0;
            var left = 0;
            var right = 0;

            while (left < nums.Length && right < nums.Length)
            {
                while (right < nums.Length && sum < target)
                {
                    sum += nums[right];
                    right++;
                }

                while (sum >= target)
                {
                    min = Math.Min(min, right - left);
                    sum -= nums[left];
                    left++;
                }
            }

            return min == int.MaxValue ? 0 : min;
        }
    }
}
