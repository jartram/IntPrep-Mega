/*
 =======================================================================================
 CHALLENGE: LongestConsecutive
 CATEGORY: CommonExercises / Hard-Array
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LongestConsecutive problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.LongestConsecutiveTests
 =======================================================================================
*/

using System;
using System.Collections.Generic;

namespace CodingExercises.CommonExercises.Hard_Array
{
    public class LongestConsecutive
    {
        public int Solve(int[] nums)
        {
            var maxLongestStreak = 0;

            var hs = new HashSet<int>(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                var actual = nums[i];

                if (!hs.Contains(actual - 1))
                {
                    var longestStreak = 0;

                    while (hs.Contains(actual))
                    {
                        longestStreak++;
                        actual++;
                    }

                    maxLongestStreak = Math.Max(maxLongestStreak, longestStreak);
                }
            }

            return maxLongestStreak;
        }
    }
}
