/*
 =======================================================================================
 CHALLENGE: ReversePolishNotation
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ReversePolishNotation problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.ReversePolishNotationTests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class ReversePolishNotation
    {
        public int EvalRPN(string[] tokens)
        {
            var stack = new Stack<int>();

            foreach (var token in tokens)
            {
                if (token == "+" || token == "-" || token == "*" || token == "/")
                {
                    var num2 = stack.Pop();
                    var num1 = stack.Pop();

                    int result;

                    if (token == "+")
                    {
                        result = num1 + num2;
                    }

                    else if (token == "-")
                    {
                        result = num1 - num2;
                    }

                    else if (token == "*")
                    {
                        result = num1 * num2;
                    }

                    else // token == "/"
                    {
                        result = num1 / num2;
                    }

                    stack.Push(result);
                }
                else
                {
                    stack.Push(int.Parse(token));
                }
            }

            return stack.Pop();
        }
    }
}
