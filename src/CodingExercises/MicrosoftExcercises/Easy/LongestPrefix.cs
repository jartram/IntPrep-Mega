/*
 =======================================================================================
 CHALLENGE: LongestPrefix
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LongestPrefix problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.LongestPrefixTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class LongestPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }

            for (int j = 0; j < strs[0].Length; j++)
            {
                var charAt = strs[0][j];

                for (int i = 1; i < strs.Length; i++)
                {
                    if (j == strs[i].Length || charAt != strs[i][j])
                    {
                        return strs[0].Substring(0, j);
                    }
                }
            }

            return strs[0];
        }
    }
}
