/*
 =======================================================================================
 CHALLENGE: FactorialTralingZeroes
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the FactorialTralingZeroes problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.FactorialTralingZeroesTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class FactorialTralingZeroes
    {
        public int TrailingZeroes(int n)
        {
            var total = 0;

            while (n > 0)
            {
                total = n / 5 + total;
                n = n / 5;
            }

            return total;
        }
    }
}