/*
 =======================================================================================
 CHALLENGE: LongestIncreasingConsecutive
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LongestIncreasingConsecutive problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.LongestIncreasingConsecutiveTests
 =======================================================================================
*/

using System;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class LongestIncreasingConsecutive
    {
        public int LongestConsecutive(int[] nums)
        {
            var hs = new HashSet<int>(nums);
            var max = 0;
            foreach (var num in nums)
            {
                if (hs.Contains(num - 1))
                {
                    continue;
                }
                var currentStreak = 1;
                var current = num + 1;
                while (hs.Contains(current))
                {
                    current = current + 1;
                    currentStreak++;
                }
                max = Math.Max(max, currentStreak);
            }
            return max;
        }
    }
}
