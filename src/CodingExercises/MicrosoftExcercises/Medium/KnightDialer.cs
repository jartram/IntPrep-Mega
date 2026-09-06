/*
 =======================================================================================
 CHALLENGE: KnightDialer
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the KnightDialer problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.KnightDialerTests
 =======================================================================================
*/

﻿using System.Collections.Generic;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class KnightDialer
    {
        // First approach
        public int TotalCount = 0;
        public int Module = 1000000007;
        public char[][] dialer;

        public int Solve(int n)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public void Backtrack(int maxLength, StringBuilder actualPhone, int i, int j)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public IEnumerable<int[]> GetValidNeighbours(int i, int j)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        ///
        public int[][] jumps;

        public int KnightDialerSolution(int n)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private const int MOD = (int)1e9 + 7;

        public int KnightDialer3(int n)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private int DFS(int n, int i, int[,] dp)
        {
            if (n == 0)
            {
                return 1;
            }

            if (dp[n, i] != 0)
            {
                return dp[n, i];
            }

            var sum = 0;

            foreach (var jump in jumps[i])
            {
                sum += DFS(n - 1, jump, dp);
            }

            dp[n, i] = sum % MOD;

            return dp[n, i];
        }
    }
}
