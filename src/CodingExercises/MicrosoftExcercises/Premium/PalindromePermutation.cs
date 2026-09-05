/*
 =======================================================================================
 CHALLENGE: PalindromePermutation
 CATEGORY: MicrosoftExcercises / Premium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the PalindromePermutation problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.PalindromePermutationTests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Premium
{
    public class PalindromePermutation
    {
        public bool CanPermute(string s)
        {
            var bucket = new int[26];

            foreach (var c in s)
            {
                bucket[c - 'a']++;
            }

            var oddFound = false;

            foreach (var item in bucket)
            {
                if (item % 2 == 1)
                {
                    if (oddFound)
                    {
                        return false;
                    }

                    oddFound = true;
                }
            }

            return true;
        }

        public bool CanPermutePalindrome(string s)
        {
            var hs = new HashSet<char>();

            foreach (var c in s)
            {
                if (hs.Contains(c))
                {
                    hs.Remove(c);
                }
                else
                {
                    hs.Add(c);
                }
            }

            return hs.Count < 2;
        }
    }
}
