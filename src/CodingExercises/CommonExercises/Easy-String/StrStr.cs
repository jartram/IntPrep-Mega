/*
 =======================================================================================
 CHALLENGE: StrStr
 CATEGORY: CommonExercises / Easy-String
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the StrStr problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.StrStrTests
 =======================================================================================
*/

namespace CodingExercises.CommonExercises.Easy_String
{
    public class StrStr
    {
        public int CalculateStrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
            {
                return 0;
            }

            // haystack = [1,2,3],-,-] actualLength = 3, i = 2, required = 5
            // needle = [3,2,1] 3
            for (int i = 0; i < haystack.Length && i + needle.Length - 1 <= haystack.Length - 1; i++)
            {
                if (haystack[i] == needle[0])
                {
                    var foundDiff = false;

                    for (int j = 0; j < needle.Length && !foundDiff; j++)
                    {
                        foundDiff = haystack[i + j] != needle[j];
                    }

                    if (!foundDiff)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
