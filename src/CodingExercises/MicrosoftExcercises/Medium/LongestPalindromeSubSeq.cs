/*
 =======================================================================================
 CHALLENGE: LongestPalindromeSubSeq
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LongestPalindromeSubSeq problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.LongestPalindromeSubSeqTests
 =======================================================================================
*/

﻿using System;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class LongestPalindromeSubSeq
    {
        public int LongestPalindromeSubseq(string s)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private int DFS(string s, int left, int right, int[,] dp)
        {
            if (left > right)
            {
                return 0;
            }

            if (left == right)
            {
                return 1;
            }

            if (dp[left, right] == 0)
            {
                if (s[left] == s[right])
                {
                    dp[left, right] = 2 + DFS(s, left + 1, right - 1, dp);
                }
                else
                {
                    dp[left, right] = Math.Max(DFS(s, left + 1, right, dp),
                                               DFS(s, left, right - 1, dp));
                }
            }

            return dp[left, right];
        }

        ///

        public int LongestPalindromeSubseqTabulation(string s)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public int LongestPalindromeSubseq2(string s)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public int LongestPalindromeSubseqReview(string s, int i, int j, int?[,] cache)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
