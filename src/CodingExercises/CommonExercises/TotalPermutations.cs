/*
 =======================================================================================
 CHALLENGE: TotalPermutations
 CATEGORY: CommonExercises
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the TotalPermutations problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.TotalPermutationsTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.Exercises
{
    public class TotalPermutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private void Backtrack(List<int> actual,
                               int[] nums,
                               HashSet<int> visited,
                               IList<IList<int>> result)
        {
            if (actual.Count == nums.Length)
            {
                result.Add(new List<int>(actual));

                return;
            }

            foreach (var num in nums)
            {
                if (!visited.Contains(num))
                {
                    visited.Add(num);
                    actual.Add(num);

                    Backtrack(actual, nums, visited, result);

                    visited.Remove(num);
                    actual.Remove(num);
                }
            }
        }
    }
}
