/*
 =======================================================================================
 CHALLENGE: CanJump
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the CanJump problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.CanJumpTests
 =======================================================================================
*/

using System;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class CanJump
    {
        public bool Solve(int[] nums)
        {
            int canWalk = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (canWalk == 0) 
                {
                    return false;
                }

                canWalk--;
                canWalk = Math.Max(canWalk, nums[i]);
            }
            return true;
        }
    }
}
