/*
 =======================================================================================
 CHALLENGE: Min2Anagram
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Min2Anagram problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.Min2AnagramTests
 =======================================================================================
*/

using System;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class Min2Anagram
    {
        public class Solution
        {
            public int MinSteps(string s, string t)
            {
                var steps = 0;

                var freq1 = new int[26];
                var freq2 = new int[26];

                for (int i = 0; i < s.Length; i++)
                {
                    freq1[t[i] - 'a']++;
                    freq2[s[i] - 'a']++;
                }

                for (int i = 0; i < 26; i++)
                {
                    steps += Math.Abs(freq1[i] - freq2[i]);
                }

                return steps / 2;
            }
        }
    }
}
