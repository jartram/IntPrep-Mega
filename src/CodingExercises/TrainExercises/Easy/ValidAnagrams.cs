/*
 =======================================================================================
 CHALLENGE: ValidAnagrams
 CATEGORY: TrainExercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ValidAnagrams problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.TrainExercises.ValidAnagramsTests
 =======================================================================================
*/

namespace CodingExercises.TrainExercises.Easy
{
    public class ValidAnagrams
    {
        public bool IsAnagram(string s, string t)
        {
            int[] bucket = new int[26];

            foreach (var character in s)
            {
                bucket[character - 'a']++;
            }

            foreach (var character in t)
            {
                bucket[character - 'a']--;
            }

            foreach (var b in bucket)
            {
                if (b != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
