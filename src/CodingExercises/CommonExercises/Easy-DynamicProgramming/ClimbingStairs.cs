/*
 =======================================================================================
 CHALLENGE: ClimbingStairs
 CATEGORY: CommonExercises / Easy-DynamicProgramming
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ClimbingStairs problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.ClimbingStairsTests
 =======================================================================================
*/

namespace CodingExercises.CommonExercises.Easy_DynamicProgramming
{
    public class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            if (n == 2)
            {
                return 2;
            }

            var arr = new int[n];

            arr[0] = 1;
            arr[1] = 2;

            for (int i = 2; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr[n - 1];
        }
    }
}
