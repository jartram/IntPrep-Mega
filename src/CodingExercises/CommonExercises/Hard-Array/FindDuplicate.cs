/*
 =======================================================================================
 CHALLENGE: FindDuplicate
 CATEGORY: CommonExercises / Hard-Array
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the FindDuplicate problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.FindDuplicateTests
 =======================================================================================
*/

namespace CodingExercises.CommonExercises.Hard_Array
{
    public class FindDuplicate
    {
        public int Solve(int[] nums)
        {
            var slow = 0;
            var fast = 0;

            while (fast < nums.Length && nums[fast] < nums.Length)
            {
                fast = nums[nums[fast]];
                slow = nums[slow];

                if (fast == slow)
                {
                    break;
                }
            }

            slow = 0;

            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }

            return slow;
        }
    }
}
