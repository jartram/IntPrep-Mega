/*
 =======================================================================================
 CHALLENGE: GenerateAllBalancedParenthesis
 CATEGORY: CommonExercises
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the GenerateAllBalancedParenthesis problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.GenerateAllBalancedParenthesisTests
 =======================================================================================
*/

﻿using System.Collections.Generic;
using System.Text;

namespace CodingExercises.Exercises
{
    public class GenerateAllBalancedParenthesis
    {
        public IList<string> GenerateParenthesis(int n)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public void Backtrack(StringBuilder path, int open, int closed, int max, IList<string> paths)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public IList<string> GenerateParenthesis2(int n)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private void DFS(int open, int close, int n, StringBuilder actual, IList<string> result)
        {
            if (n == open && n == close)
            {
                result.Add(actual.ToString());
            }

            if (open < n)
            {
                actual.Append('(');
                DFS(open + 1, close, n, actual, result);
                actual.Length = actual.Length - 1;
            }

            if (close < open)
            {
                actual.Append(')');
                DFS(open, close + 1, n, actual, result);
                actual.Length = actual.Length - 1;
            }
        }
    }
}
