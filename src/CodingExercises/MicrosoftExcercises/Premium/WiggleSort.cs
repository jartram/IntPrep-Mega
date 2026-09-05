/*
 =======================================================================================
 CHALLENGE: WiggleSort
 CATEGORY: MicrosoftExcercises / Premium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the WiggleSort problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.WiggleSortTests
 =======================================================================================
*/

﻿namespace CodingExercises.MicrosoftExcercises.Premium
{
    public class WiggleSort
    {
        public void Solve(int[] nums)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private void Swap(int[] nums, int i, int j)
        {
            var aux = nums[i];
            nums[i] = nums[j];
            nums[j] = aux;
        }
    }
}
