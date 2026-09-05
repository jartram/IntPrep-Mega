/*
 =======================================================================================
 CHALLENGE: RemoveDuplicatesFromSortedArray
 CATEGORY: CommonExercises / Easy-Array
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the RemoveDuplicatesFromSortedArray problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.RemoveDuplicatesFromSortedArrayTests
 =======================================================================================
*/

namespace CodingExercises.CommonExercises.Easy_Array
{
    public class RemoveDuplicatesFromSortedArray

    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums.Length;
            }

            var leftPosition = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    nums[leftPosition] = nums[i];
                    leftPosition++;
                }
            }

            return leftPosition;
        }
    }
}
