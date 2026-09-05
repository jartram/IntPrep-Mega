/*
 =======================================================================================
 CHALLENGE: MoveZeroes
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MoveZeroes problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.MoveZeroesTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class MoveZeroes
    {
        public void Solve(int[] nums)
        {
            var leftPosition = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[leftPosition] = nums[i];
                    if (i != leftPosition)
                    {
                        nums[i] = 0;
                    }

                    leftPosition++;
                }
            }
        }
    }
}
