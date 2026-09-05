/*
 =======================================================================================
 CHALLENGE: RegularExpressionMatching
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the RegularExpressionMatching problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.RegularExpressionMatchingTests
 =======================================================================================
*/

﻿namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class RegularExpressionMatching
    {
        public bool IsMatch(string text, string pattern)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private bool IsMatch(int i, int j, string text, string pattern, bool?[,] dp)
        {
            if (dp[i, j] != null)
            {
                return dp[i, j].Value;
            }

            bool result;

            if (j == pattern.Length)
            {
                result = i == text.Length;
            }
            else
            {
                var firstMatch = (i < text.Length && (text[i] == pattern[j] || pattern[j] == '.'));

                if (j + 1 < pattern.Length && pattern[j + 1] == '*')
                {
                    result = (IsMatch(i, j + 2, text, pattern, dp) || (firstMatch && IsMatch(i + 1, j, text, pattern, dp)));
                }
                else
                {
                    result = firstMatch && IsMatch(i + 1, j + 1, text, pattern, dp);
                }
            }

            dp[i, j] = result;

            return result;
        }
    }
}
