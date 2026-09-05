/*
 =======================================================================================
 CHALLENGE: AddStrings
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the AddStrings problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.AddStringsTests
 =======================================================================================
*/

using System;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class AddStrings
    {
        public string Solve(string num1, string num2)
        {
            var carry = 0;
            var i = num1.Length - 1;
            var j = num2.Length - 1;
            var result = new char[Math.Max(i, j) + 2];
            var resultIndex = result.Length - 1;

            while (i >= 0 || j >= 0)
            {
                var n1 = i < 0 ? 0 : int.Parse(num1[i].ToString());
                var n2 = j < 0 ? 0 : int.Parse(num2[j].ToString());

                var sum = n1 + n2 + carry;

                result[resultIndex] = (char)('0' + sum % 10);

                carry = sum / 10;
                resultIndex--;
                i--;
                j--;
            }

            if (carry > 0)
            {
                result[0] = (char)('0' + carry);

                return new string(result);
            }
            else
            {
                return new string(result).Substring(1, result.Length - 1);
            }
        }
    }
}
