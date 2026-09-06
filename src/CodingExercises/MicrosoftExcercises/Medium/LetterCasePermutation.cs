/*
 =======================================================================================
 CHALLENGE: LetterCasePermutation
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LetterCasePermutation problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.LetterCasePermutationTests
 =======================================================================================
*/

﻿using System.Collections.Generic;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class LetterCasePermutation
    {
        public IList<string> Solve(string S)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private void Backtrack(string str, StringBuilder permutation, IList<string> permutations)
        {
            if (permutation.Length == str.Length)
            {
                permutations.Add(permutation.ToString());

                return;
            }

            var validChars = CalculateValidPermutations(str, permutation.Length);

            foreach (var validChar in validChars)
            {
                permutation.Append(validChar);

                Backtrack(str, permutation, permutations);

                permutation.Remove(permutation.Length - 1, 1);
            }
        }

        private IList<char> CalculateValidPermutations(string str, int index)
        {
            var validChars = new List<char>();
            var actualLetter = str[index];

            if (char.IsLetter(actualLetter))
            {
                validChars.Add(char.ToUpper(actualLetter));
                validChars.Add(char.ToLower(actualLetter));
            }
            else
            {
                validChars.Add(actualLetter);
            }

            return validChars;
        }
    }
}
