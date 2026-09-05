/*
 =======================================================================================
 CHALLENGE: WiggleSort
 CATEGORY: MicrosoftExcercises / Premium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the WiggleSort problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.WiggleSortTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Premium
{
    public class WiggleSort
    {
        public void Solve(int[] nums)
        {
            bool isLess = true;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if ((isLess && nums[i] > nums[i + 1]) || (!isLess && nums[i] < nums[i + 1]))
                {
                    Swap(nums, i, i + 1);
                }

                isLess = !isLess;
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            var aux = nums[i];
            nums[i] = nums[j];
            nums[j] = aux;
        }
    }
}
