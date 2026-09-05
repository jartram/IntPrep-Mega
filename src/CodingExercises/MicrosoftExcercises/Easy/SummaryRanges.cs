/*
 =======================================================================================
 CHALLENGE: SummaryRanges
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the SummaryRanges problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.SummaryRangesTests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class SummaryRanges
    {
        public IList<string> Solve(int[] nums)
        {
            var result = new List<string>();
            int i = 0;
            int? prev;

            while (i < nums.Length)
            {
                var start = nums[i];
                prev = null;

                while (i < nums.Length && (prev == null || (nums[i] - prev == 1)))
                {
                    prev = nums[i];
                    i++;
                }

                var range = start == prev ? $"{start}" : $"{start}->{prev}";

                result.Add(range);
            }

            return result;
        }
    }
}
