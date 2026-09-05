/*
 =======================================================================================
 CHALLENGE: Monotonic
 CATEGORY: CommonExercises
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Monotonic problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.MonotonicTests
 =======================================================================================
*/

namespace CodingExercises.Exercises
{
    public class Monotonic
    {
        public bool isMonotonic(int[] A)
        {
            bool increasing = true;
            bool decreasing = true;

            for (int i = 0; i < A.Length - 1; ++i)
            {
                if (A[i] > A[i + 1])
                    increasing = false;
                if (A[i] < A[i + 1])
                    decreasing = false;
            }

            return increasing || decreasing;
        }
    }
}
