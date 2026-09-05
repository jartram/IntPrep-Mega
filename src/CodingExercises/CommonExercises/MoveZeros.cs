/*
 =======================================================================================
 CHALLENGE: MoveZeroesClass
 CATEGORY: CommonExercises
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MoveZeroesClass problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.MoveZeroesClassTests
 =======================================================================================
*/

namespace CodingExercises.Exercises
{
    public class MoveZeroesClass
    {
        public void MoveZeroes(int[] nums)
        {
            var fillIndex = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (fillIndex == -1)
                {
                    fillIndex = nums[i] == 0 ? i : -1;
                }
                else if (i != fillIndex && nums[i] != 0)
                {
                    nums[fillIndex] = nums[i];
                    fillIndex++;
                    nums[i] = 0;
                }
            }
        }
    }
}
