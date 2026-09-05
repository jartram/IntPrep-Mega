/*
 =======================================================================================
 CHALLENGE: HouseRobber
 CATEGORY: CommonExercises / Easy-DynamicProgramming
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the HouseRobber problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.HouseRobberTests
 =======================================================================================
*/

using System;

namespace CodingExercises.CommonExercises.Easy_DynamicProgramming
{
    public class HouseRobber
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            if (nums.Length == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }

            var prevPrev = nums[0];
            var prev = Math.Max(nums[0], nums[1]);
            int current = 0;

            for (int i = 2; i < nums.Length; i++)
            {
                current = Math.Max(prevPrev + nums[i], prev);
                prevPrev = prev;
                prev = current;
            }

            return current;
        }
    }
}
