/*
 =======================================================================================
 CHALLENGE: ReverseWords
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ReverseWords problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.ReverseWordsTests
 =======================================================================================
*/

using System.Text;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class ReverseWords
    {
        public string Solve(string s)
        {
            var sb = new StringBuilder();
            int i = 0;

            while (i < s.Length)
            {
                while (i < s.Length && s[i] == ' ')
                {
                    i++;
                }

                var actual = new StringBuilder();

                while (i < s.Length && char.IsLetterOrDigit(s[i]))
                {
                    actual.Append(s[i]);
                    i++;
                }
                actual.Append(' ');

                sb.Insert(0, actual.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
