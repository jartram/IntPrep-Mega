/*
 =======================================================================================
 CHALLENGE: FindAllDuplicates
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the FindAllDuplicates problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.FindAllDuplicatesTests
 =======================================================================================
*/

using System;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class FindAllDuplicates
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            var duplicates = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var nextIndex = Math.Abs(nums[i]) - 1;

                if (nums[nextIndex] < 0)
                {
                    duplicates.Add(nextIndex + 1);
                }
                else
                {
                    nums[nextIndex] = nums[nextIndex] * -1;
                }
            }

            return duplicates;
        }
    }
}
