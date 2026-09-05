/*
 =======================================================================================
 CHALLENGE: SubSequenceCheck
 CATEGORY: CommonExercises
 SOURCE: https://leetcode.com/problems/is-subsequence/
 
 DESCRIPTION:
 Solve the SubSequenceCheck problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.SubSequenceCheckTests
 =======================================================================================
*/

namespace CodingExercises.Exercises
{
    public class SubSequenceCheck
    {

        // problem: https://leetcode.com/problems/is-subsequence/
        // cool video: https://www.youtube.com/watch?v=UsPWwTY0xr4&ab_channel=NareshGupta

        public static bool IsSubsequence(string s, string t)
        {
            var i = 0;
            var j = 0;

            while (i < s.Length && j < t.Length)
            {
                if (s[i] == s[j])
                {
                    i++;
                }

                j++;
            }

            return i == s.Length;
        }
    }
}
