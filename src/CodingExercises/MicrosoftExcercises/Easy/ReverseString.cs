/*
 =======================================================================================
 CHALLENGE: ReverseString
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ReverseString problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.ReverseStringTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class ReverseString
    {
        public void Solve(char[] s)
        {
            int i = 0;
            int j = s.Length - 1;
            char tmp;

            while (i < j)
            {
                tmp = s[i];
                s[i] = s[j];
                s[j] = tmp;

                i++;
                j--;
            }
        }
    }
}
