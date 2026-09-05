/*
 =======================================================================================
 CHALLENGE: TwoSumSorted
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the TwoSumSorted problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.TwoSumSortedTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class TwoSumSorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var i = 0;
            var j = numbers.Length - 1;

            while (i < j)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    return new int[] { i + 1, j + 1 };
                }
                else if (numbers[i] + numbers[j] > target)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }

            return null;
        }
    }
}
