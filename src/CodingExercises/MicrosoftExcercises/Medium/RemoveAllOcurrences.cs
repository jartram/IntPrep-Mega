/*
 =======================================================================================
 CHALLENGE: RemoveAllOcurrences
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the RemoveAllOcurrences problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.RemoveAllOcurrencesTests
 =======================================================================================
*/

using System.Text;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class RemoveAllOcurrences
    {
        public string RemoveOccurrences(string s, string part)
        {
            var result = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                result.Append(s[i]);

                if (result.Length >= part.Length &&
                   result.ToString().Substring(result.Length - part.Length) == part)
                {
                    result.Length -= part.Length;
                }
            }

            return result.ToString();
        }
    }
}
