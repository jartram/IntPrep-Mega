/*
 =======================================================================================
 CHALLENGE: CheckSubarraySum
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the CheckSubarraySum problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.CheckSubarraySumTests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class CheckSubarraySum
    {
        public bool Solve(int[] nums, int k)
        {
            var indexes = new Dictionary<int, int>()
        {
            {0, -1}
        };
            var sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum = (sum + nums[i]) % k;

                if (indexes.ContainsKey(sum))
                {
                    var index = indexes[sum];

                    if (i - index > 1)
                    {
                        return true;
                    }
                }
                else
                {
                    indexes.Add(sum, i);
                }
            }

            return false;
        }
    }
}
