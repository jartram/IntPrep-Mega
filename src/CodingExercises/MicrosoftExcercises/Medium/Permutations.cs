/*
 =======================================================================================
 CHALLENGE: Permutations
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Permutations problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.PermutationsTests
 =======================================================================================
*/

﻿using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class Permutations
    {
        public HashSet<int> visited { get; set; } = new HashSet<int>();

        public IList<IList<int>> Permute(int[] nums)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public void Backtrack(int[] nums, IList<IList<int>> result)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
