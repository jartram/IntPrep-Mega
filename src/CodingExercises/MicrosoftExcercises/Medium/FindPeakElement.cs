/*
 =======================================================================================
 CHALLENGE: FindPeakElement
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the FindPeakElement problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.FindPeakElementTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class FindPeakElement
    {
        public int Solve(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] > nums[mid + 1])
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }
    }
}
