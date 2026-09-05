/*
 =======================================================================================
 CHALLENGE: SolveMyPow
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the SolveMyPow problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.SolveMyPowTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class SolveMyPow
    {
        public double Solve(double x, int n)
        {
            if (n < 0) return 1 / x * Solve(1 / x, -(n + 1));
            if (n == 0) return 1;
            if (n == 1) return x;
            if (n % 2 == 0) return Solve(x * x, n / 2);
            return x * Solve(x * x, n / 2);
        }
    }
}
