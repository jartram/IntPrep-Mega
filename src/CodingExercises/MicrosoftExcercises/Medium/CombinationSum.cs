/*
 =======================================================================================
 CHALLENGE: CombinationSum
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the CombinationSum problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.CombinationSumTests
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class CombinationSum
    {
        private IList<IList<int>> combinations;

        public IList<IList<int>> Solve(int[] candidates, int target)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private void Backtrack(int[] candidates, int target, Stack<int> currentCombination, int initialIndex)
        {
            if (target == 0)
            {
                combinations.Add(currentCombination.ToList());

                return;
            }

            if (currentCombination.Count >= 150)
            {
                return;
            }

            for (int i = initialIndex; i < candidates.Length; i++)
            {
                var candidate = candidates[i];

                if (target - candidate >= 0)
                {
                    currentCombination.Push(candidate);

                    Backtrack(candidates, target - candidate, currentCombination, i);

                    currentCombination.Pop();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
