/*
 =======================================================================================
 CHALLENGE: RemoveElements
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the RemoveElements problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.RemoveElementsTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class RemoveElements
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums.Length;
            }
            var leftPosition = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[leftPosition] != nums[i])
                {
                    leftPosition++;
                    nums[leftPosition] = nums[i];
                }
            }

            return leftPosition + 1;
        }
    }
}
