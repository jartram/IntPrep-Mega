/*
 =======================================================================================
 CHALLENGE: CombinationSumIII
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the CombinationSumIII problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.CombinationSumIIITests
 =======================================================================================
*/

﻿using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class CombinationSumIII
    {
        public int[] candidates;

        public IList<IList<int>> combinations;

        public IList<IList<int>> CombinationSum3(int k, int target)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public void Backtrack(int currentIndex,
                              int target,
                              List<int> combination,
                              int k)
        {
            if (target == 0 && combination.Count == k)
            {
                combinations.Add(combination.ToList());

                return;
            }

            if (combination.Count > k)
            {
                return;
            }

            for (int i = currentIndex; i < candidates.Length; i++)
            {
                if (i > currentIndex && candidates[i] == candidates[i - 1])
                {
                    continue;
                };

                var candidate = candidates[i];

                if (target - candidate >= 0)
                {
                    combination.Add(candidate);

                    Backtrack(i + 1, target - candidate, combination, k);

                    combination.RemoveAt(combination.Count - 1);
                }
            }
        }
    }
}
