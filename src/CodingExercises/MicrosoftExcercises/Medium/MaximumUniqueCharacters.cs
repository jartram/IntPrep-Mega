/*
 =======================================================================================
 CHALLENGE: MaximumUniqueCharacters
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MaximumUniqueCharacters problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.MaximumUniqueCharactersTests
 =======================================================================================
*/

using System.Linq;
﻿using System;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class MaximumUniqueCharacters
    {
        public int MaxLength(IList<string> arr)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private void Backtrack(int start, IList<HashSet<char>> sets, ref int max, HashSet<char> current)
        {

            if (max == 26)
            {
                return;
            }

            if (start > sets.Count)
            {
                return;
            }

            for (int i = start; i < sets.Count; i++)
            {
                var actualSet = sets[i];

                if (IsValid(current, actualSet))
                {
                    current.UnionWith(actualSet);

                    max = Math.Max(max, current.Count);

                    Backtrack(i, sets, ref max, current);

                    current.ExceptWith(actualSet);
                }
            }
        }

        private bool IsValid(HashSet<char> h1, HashSet<char> h2)
        {
            foreach (var ch in h1)
            {
                if (h2.Contains(ch))
                {
                    return false;
                }
            }

            return true;
        }

        private IList<HashSet<char>> BuildHashSets(IList<string> arrs)
        {
            var seen = new HashSet<int>();

            var sets = new List<HashSet<char>>();

            foreach (var arr in arrs)
            {
                var set = arr.ToHashSet();

                if (set.Count == arr.Length)
                {
                    var hashCode = set.GetHashCode();

                    if (!seen.Contains(hashCode))
                    {
                        seen.Add(set.GetHashCode());
                        sets.Add(set);
                    }
                }
            }

            return sets;
        }
    }
}
