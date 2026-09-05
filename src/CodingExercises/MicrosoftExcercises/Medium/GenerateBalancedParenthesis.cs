/*
 =======================================================================================
 CHALLENGE: GenerateBalancedParenthesis
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the GenerateBalancedParenthesis problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.GenerateBalancedParenthesisTests
 =======================================================================================
*/

using System.Collections.Generic;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class GenerateBalancedParenthesis
    {
        public IList<string> result;
        public IList<string> GenerateParenthesis(int n)
        {
            result = new List<string>();
            Backtrack(n, 0, new StringBuilder(), 0, 0);
            return result;
        }
        public void Backtrack(int n, int total, StringBuilder actual, int open, int closed)
        {
            if (total == n * 2)
            {
                result.Add(actual.ToString());
                return;
            }
            if (open < n)
            {
                actual.Append('(');
                Backtrack(n, total + 1, actual, open + 1, closed);
                actual.Remove(actual.Length - 1, 1);
            }
            if (closed < open)
            {
                actual.Append(')');
                Backtrack(n, total + 1, actual, open, closed + 1);
                actual.Remove(actual.Length - 1, 1);
            }
        }
    }
}
