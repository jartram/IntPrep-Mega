/*
 =======================================================================================
 CHALLENGE: TwoSum
 CATEGORY: CommonExercises / Easy-Array
 SOURCE: https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/546/
 
 DESCRIPTION:
 Solve the TwoSum problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.TwoSumTests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.CommonExercises.Easy_Array
{
    //https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/546/
    public class TwoSum
    {
        public int[] GetTwoSum(int[] nums, int target)
        {
            var hs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (hs.ContainsKey(target - nums[i]))
                {
                    return new int[] { i, hs[target - nums[i]] };
                }
                else
                {
                    hs.Add(nums[i], i);
                }
            }

            return null;
        }
    }
}
