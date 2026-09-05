/*
 =======================================================================================
 CHALLENGE: ExcelTitle
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ExcelTitle problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.ExcelTitleTests
 =======================================================================================
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class ExcelTitle
    {
        public string ConvertToTitle(int columnNumber)
        {
            var sb = new StringBuilder();
            var stack = new Stack<char>();

            while (columnNumber > 0)
            {
                columnNumber--;
                stack.Push((char)(columnNumber % 26 + 'A'));
                columnNumber /= 26;
            }

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Peek());
                sb.Append(stack.Pop());
            }

            return sb.ToString();
        }
    }
}
