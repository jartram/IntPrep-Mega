/*
 =======================================================================================
 CHALLENGE: ReverseOnlyLetters
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ReverseOnlyLetters problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.ReverseOnlyLettersTests
 =======================================================================================
*/

using System.Text;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class ReverseOnlyLetters
    {
        public string Solve(string s)
        {
            var next = 0;
            var right = s.Length - 1;
            var sb = new StringBuilder();

            for (int i = right; i >= 0; i--)
            {
                while (next < s.Length && !char.IsLetter(s[next]))
                {
                    sb.Append(s[next]);
                    next++;
                }

                if (char.IsLetter(s[i]))
                {
                    sb.Append(s[i]);

                    next++;
                }
            }

            while (next < s.Length && !char.IsLetter(s[next]))
            {
                sb.Append(s[next]);
                next++;
            }

            return sb.ToString();
        }
    }
}
