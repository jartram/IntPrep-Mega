/*
 =======================================================================================
 CHALLENGE: StringWOAAABBB
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the StringWOAAABBB problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.StringWOAAABBBTests
 =======================================================================================
*/

using System.Text;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class StringWOAAABBB
    {
        public string StrWithout3a3b(int a, int b)
        {
            var sb = new StringBuilder();

            while (a > 0 || b > 0)
            {
                if (a > b)
                {
                    if (IsValid(sb.ToString(), 'a'))
                    {
                        sb.Append("a");
                        a--;
                    }
                    else
                    {
                        sb.Append("b");
                        b--;
                    }
                }
                else
                {
                    if (IsValid(sb.ToString(), 'b'))
                    {
                        sb.Append("b");
                        b--;
                    }
                    else
                    {
                        sb.Append("a");
                        a--;
                    }
                }
            }

            return sb.ToString();
        }

        private bool IsValid(string str, char c)
        {
            return str.Length < 2 || str.Substring(str.Length - 2) != $"{c}{c}";
        }
    }
}
