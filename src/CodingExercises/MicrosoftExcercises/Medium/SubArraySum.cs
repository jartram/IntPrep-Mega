/*
 =======================================================================================
 CHALLENGE: SubArraySum
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the SubArraySum problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.SubArraySumTests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class SubArraySum
    {
        public int SubarraySum(int[] nums, int k)
        {
            var total = 0;
            var sum = 0;
            var accumulatorMap = new Dictionary<int, int>();
            accumulatorMap.Add(0, 1);
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (accumulatorMap.ContainsKey(sum - k))
                {
                    total += accumulatorMap[sum - k];
                }
                if (!accumulatorMap.ContainsKey(sum))
                {
                    accumulatorMap.Add(sum, 0);
                }
                accumulatorMap[sum]++;
            }
            return total;
        }
    }
}
