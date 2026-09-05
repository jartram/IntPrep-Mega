/*
 =======================================================================================
 CHALLENGE: FirstMissingPositiveSWAP
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the FirstMissingPositiveSWAP problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.FirstMissingPositiveSWAPTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class FirstMissingPositiveSWAP
    {
        public int FirstMissingPositive(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[i] > 0 && nums[i] - 1 < nums.Length &&
                      nums[i] != i + 1 &&
                      nums[i] != nums[nums[i] - 1])
                {
                    var tmp = nums[i];
                    nums[i] = nums[nums[i] - 1];
                    nums[tmp - 1] = tmp;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                {
                    return i + 1;
                }
            }

            return nums.Length + 1;
        }
    }
}
