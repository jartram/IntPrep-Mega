/*
 =======================================================================================
 CHALLENGE: LongestSubstringNoRepeat
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LongestSubstringNoRepeat problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.LongestSubstringNoRepeatTests
 =======================================================================================
*/

using System;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class LongestSubstringNoRepeat
    {
        public int LengthOfLongestSubstring(string s)
        {
            var positions = new Dictionary<char, int>();
            var longest = 0;
            var i = 0;
            for (int j = 0; j < s.Length; j++)
            {
                var visited = positions.ContainsKey(s[j]);

                if (visited)
                {
                    i = Math.Max(i, positions[s[j]]);
                }

                longest = Math.Max(longest, j - i + 1);

                if (visited)
                {
                    positions[s[j]] = j + 1;
                }
                else
                {
                    positions.Add(s[j], j + 1);
                }
            }

            return longest;
        }

        public int LengthOfLongestSubstringReview(string s)
        {
            var dict = new Dictionary<char, int>();
            var max = 0;
            var lastIndex = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var actual = s[i];

                if (dict.ContainsKey(actual))
                {
                    lastIndex = Math.Max(lastIndex, dict[actual] + 1);
                }

                dict[actual] = i;

                max = Math.Max(max, i - lastIndex + 1);
            }

            return max;
        }
    }
}
