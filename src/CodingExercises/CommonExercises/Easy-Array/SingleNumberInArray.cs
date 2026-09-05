/*
 =======================================================================================
 CHALLENGE: SingleNumberInArray
 CATEGORY: CommonExercises / Easy-Array
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the SingleNumberInArray problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.SingleNumberInArrayTests
 =======================================================================================
*/

namespace CodingExercises.CommonExercises.Easy_Array
{
    public class SingleNumberInArray
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                result = result ^ nums[i];
            }

            return result;
        }
    }
}
