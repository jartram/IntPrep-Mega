/*
 =======================================================================================
 CHALLENGE: LetterTotalCombinations
 CATEGORY: CommonExercises
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LetterTotalCombinations problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.LetterTotalCombinationsTests
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercises.Exercises
{
    public class LetterTotalCombinations
    {
        public IList<string> LetterCombinations(string digits)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private void Backtrack(int index,
                               StringBuilder path,
                               IList<string> combinations,
                               Dictionary<char, char[]> dictionary,
                               string digits)
        {
            if (path.Length == digits.Length)
            {
                combinations.Add(path.ToString());
                return;
            }

            var letterCombinations = dictionary[digits[index]];

            foreach (var letter in letterCombinations)
            {
                path.Append(letter);

                Backtrack(index + 1, path, combinations, dictionary, digits);

                path.Remove(path.Length - 1, 1);
            }
        }
    }
}

