/*
 =======================================================================================
 CHALLENGE: FindDiff
 CATEGORY: TrainExercises / Easy
 SOURCE: https://leetcode.com/problems/find-the-difference/
 
 DESCRIPTION:
 Solve the FindDiff problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.TrainExercises.FindDiffTests
 =======================================================================================
*/

namespace CodingExercises.TrainExercises.Easy
{
    public class FindDiff
    {
        // https://leetcode.com/problems/find-the-difference/
        public char FindTheDifference(string s, string t)
        {
            var bucket = new int[26];

            foreach (var c in s)
            {
                bucket[c - 'a']++;
            }

            foreach (var c in t)
            {
                bucket[c - 'a']--;
            }

            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != 0)
                {
                    return (char)(i + 'a');
                }
            }

            return 'a';
        }
    }
}
