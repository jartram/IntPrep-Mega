/*
 =======================================================================================
 CHALLENGE: FirstUniqueCharcs
 CATEGORY: CommonExercises / Easy-String
 SOURCE: https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/881/
 
 DESCRIPTION:
 Solve the FirstUniqueCharcs problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.FirstUniqueCharcsTests
 =======================================================================================
*/

namespace CodingExercises.CommonExercises.Easy_String
{
    //https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/881/
    public class FirstUniqueCharcs
    {
        public int FirstUniqChar(string s)
        {

            // -1 repeated
            // 0 not found
            // > 0 arr[i] - 1 = position
            var charPositions = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                if (charPositions[s[i] - 'a'] == 0)
                {
                    charPositions[s[i] - 'a'] = i + 1;
                }
                else
                {
                    charPositions[s[i] - 'a'] = -1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charPositions[s[i] - 'a'] > 0)
                {
                    return charPositions[s[i] - 'a'] - 1;
                }
            }

            return -1;
        }
    }
}
