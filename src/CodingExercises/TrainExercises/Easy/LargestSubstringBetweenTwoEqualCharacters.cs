/*
 =======================================================================================
 CHALLENGE: LargestSubstringBetweenTwoEqualCharacters
 CATEGORY: TrainExercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LargestSubstringBetweenTwoEqualCharacters problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.TrainExercises.LargestSubstringBetweenTwoEqualCharactersTests
 =======================================================================================
*/

using System;
using System.Collections.Generic;

namespace CodingExercises.TrainExercises.Easy
{
    public class LargestSubstringBetweenTwoEqualCharacters
    {
        public int MaxLengthBetweenEqualCharacters(string s)
        {
            var max = -1;

            var dictionaryFirstPosition = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dictionaryFirstPosition.ContainsKey(s[i]))
                {
                    max = Math.Max(max, i - dictionaryFirstPosition[s[i]] - 1);
                }
                else
                {
                    dictionaryFirstPosition.Add(s[i], i);
                }
            }

            return max;
        }
    }
}
