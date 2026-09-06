/*
 =======================================================================================
 CHALLENGE: TotalAnagrams
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the TotalAnagrams problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.TotalAnagramsTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class TotalAnagrams
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private int[] BuildFrequency(string p)
        {
            var freq = new int[26];

            foreach (var c in p)
            {
                freq[c - 'a']++;
            }

            return freq;
        }
    }
}
