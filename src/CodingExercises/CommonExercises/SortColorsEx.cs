/*
 =======================================================================================
 CHALLENGE: SortColorsEx
 CATEGORY: CommonExercises
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the SortColorsEx problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.SortColorsExTests
 =======================================================================================
*/

namespace CodingExercises.Exercises
{
    public class SortColorsEx
    {
        public void SortColors(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;
            var index = 0;

            while (index <= right)
            {
                var actual = nums[index];

                if (actual == 0)
                {
                    Swap(left, index, nums);
                    left++;
                    index++;
                }
                else if (actual == 1)
                {
                    index++;
                }
                else // actual == 2
                {
                    Swap(right, index, nums);
                    right--;
                }
            }
        }

        public void Swap(int i, int j, int[] nums)
        {
            var aux = nums[i];

            nums[i] = nums[j];
            nums[j] = aux;
        }
    }
}
