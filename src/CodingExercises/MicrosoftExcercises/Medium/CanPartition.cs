/*
 =======================================================================================
 CHALLENGE: CanPartition
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the CanPartition problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.CanPartitionTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class CanPartition
    {
        public bool Solve(int[] nums)
        {
            var sum = 0;

            foreach (var num in nums)
            {
                sum += num;
            }

            if (sum % 2 == 0)
            {
                return CanPartitionAux(nums, sum / 2);
            }

            return false;
        }

        private bool CanPartitionAux(int[] nums, int target)
        {
            var n = nums.Length;
            var m = target + 1;
            var dp = new bool[m];
            dp[0] = true;


            foreach (var num in nums)
            {
                for (int j = target; j >= num; j--)
                {
                    dp[j] = dp[j] || dp[j - num];
                }
            }

            return dp[m - 1];
        }
    }
}
