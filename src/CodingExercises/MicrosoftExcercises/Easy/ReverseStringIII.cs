/*
 =======================================================================================
 CHALLENGE: ReverseStringIII
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ReverseStringIII problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.ReverseStringIIITests
 =======================================================================================
*/

using System;
using System.Linq;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class ReverseStringIII
    {
        public string SolveFirstApproach(string s)
        {
            var split = s.Split(" ");

            for (int i = 0; i < split.Length; i++)
            {
                split[i] = new string(split[i].Reverse().ToArray());
            }

            return string.Join(" ", split);
        }


        //second approach
        public string ReverseWords(string s)
        {
            var result = new StringBuilder();

            int i = 0;

            while (i <= s.Length)
            {
                var start = i;

                while (i != s.Length && s[i] != ' ')
                {
                    i++;
                }

                result.Append(Reverse(s, start, i - 1));

                i++;
            }

            return result.ToString();
        }

        public string Reverse(string s, int start, int end)
        {
            var sb = new StringBuilder();

            for (int i = end; i >= start; i--)
            {
                sb.Append(s[i]);
            }

            if (end + 1 != s.Length)
            {
                sb.Append(" ");
            }

            return sb.ToString();
        }
    }
}
