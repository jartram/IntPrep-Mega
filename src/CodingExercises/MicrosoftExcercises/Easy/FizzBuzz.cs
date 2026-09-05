/*
 =======================================================================================
 CHALLENGE: FizzBuzz
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the FizzBuzz problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.FizzBuzzTests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class FizzBuzz
    {
        public IList<string> Solve(int n)
        {
            var result = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                var div3 = i % 3 == 0;
                var div5 = i % 5 == 0;

                if (div3 && div5)
                {
                    result.Add("FizzBuzz");
                }
                else if (div3)
                {
                    result.Add("Fizz");
                }
                else if (div5)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add($"{i}");
                }
            }

            return result;
        }
    }
}
