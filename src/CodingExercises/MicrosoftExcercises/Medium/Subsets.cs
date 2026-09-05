/*
 =======================================================================================
 CHALLENGE: Subsets
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Subsets problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.SubsetsTests
 =======================================================================================
*/

using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class Subsets
    {
        public IList<IList<int>> Solve(int[] nums)
        {
            var subsets = new List<IList<int>>();

            Backtrack(nums, subsets, 0, new HashSet<int>());

            return subsets;
        }

        public void Backtrack(int[] nums, IList<IList<int>> subsets, int start, HashSet<int> subset)
        {
            subsets.Add(subset.ToList());

            for (int i = start; i < nums.Length; i++)
            {
                var candidate = nums[i];
                subset.Add(candidate);

                Backtrack(nums, subsets, i + 1, subset);

                subset.Remove(candidate);
            }
        }
    }
}
