/*
 =======================================================================================
 CHALLENGE: MoveZeroes
 CATEGORY: CommonExercises / Easy-Array
 SOURCE: https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/567/
 
 DESCRIPTION:
 Solve the MoveZeroes problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.MoveZeroesTests
 =======================================================================================
*/

namespace CodingExercises.CommonExercises.Easy_Array
{
    // https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/567/
    public class MoveZeroes
    {
        public void Move(int[] nums)
        {
            var fillIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (fillIndex != i)
                    {
                        nums[fillIndex] = nums[i];
                        nums[i] = 0;
                    }

                    fillIndex++;
                }
            }
        }
    }
}
