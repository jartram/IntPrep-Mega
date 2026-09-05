/*
 =======================================================================================
 CHALLENGE: FindTheDuplicateNumber
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the FindTheDuplicateNumber problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.FindTheDuplicateNumberTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class FindTheDuplicateNumber
    {
        public int FindDuplicate(int[] nums)
        {
            int fast = nums[0];
            int slow = nums[0];

            do
            {
                fast = nums[nums[fast]];
                slow = nums[slow];
            } while (slow != fast);

            slow = nums[0];

            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }

            return slow;
        }
    }
}
