/*
 =======================================================================================
 CHALLENGE: JumpGame
 CATEGORY: CommonExercises / Medium-DynamicProgramming
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the JumpGame problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.JumpGameTests
 =======================================================================================
*/

using System;

namespace CodingExercises.Exercises.DynamicProgramming
{
    public class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return false;
            }

            var maxJumps = new int[nums.Length];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (i == 0)
                {
                    maxJumps[0] = nums[0];
                }
                else
                {
                    maxJumps[i] = Math.Max(maxJumps[i - 1] - 1, nums[i]);
                }

                if (maxJumps[i] == 0)
                {
                    return false;
                }
            }

            return true;
        }

        //Greedy approach

        public bool CanJumpGreedy(int[] nums)
        {
            int lastGoodPosition = nums.Length - 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                lastGoodPosition = i + nums[i] >= lastGoodPosition ? i : lastGoodPosition;
            }

            return lastGoodPosition == 0;
        }
    }
}
