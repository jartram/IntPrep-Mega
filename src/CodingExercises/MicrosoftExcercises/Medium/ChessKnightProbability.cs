/*
 =======================================================================================
 CHALLENGE: ChessKnightProbability
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ChessKnightProbability problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.ChessKnightProbabilityTests
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class ChessKnightProbability
    {
        private int[] Xs = { -2, -1, 1, 2, -2, -1, 1, 2 };
        private int[] Ys = { -1, -2, -2, -1, 1, 2, 2, 1 };

        private double TotalPossibleMoves = 0;
        private double TotalPaths = 0;
        private IList<int[]>[,] ValidMoves;

        //THIS IS A TLE, the memoization here isnt the best. IF the memo is improved, then the solution will be accepted
        public double KnightProbability(int n, int k, int row, int column)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public void CalculateTotalValidMoves(int n, int k, int i, int j)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private IList<int[]> CalculateActualValidMoves(int i, int j, int n)
        {
            var result = new List<int[]>();

            for (int x = 0; x < Xs.Length; x++)
            {
                var newI = i + Ys[x];
                var newJ = j + Xs[x];

                if (newI >= 0 && newI < n && newJ >= 0 && newJ < n)
                {
                    result.Add(new int[] { newI, newJ });
                }
            }

            return result;
        }
    }

    //memo optimized :)

    public class Solution
    {
        private int[] Xs = { -2, -1, 1, 2, -2, -1, 1, 2 };
        private int[] Ys = { -1, -2, -2, -1, 1, 2, 2, 1 };

        public double KnightProbability(int n, int k, int row, int column)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public double KnightProbability(int n, int k, int row, int column, double[,,] cache)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private IList<int[]> BuildNeighbours(int row, int col, int n)
        {
            var neighbours = new List<int[]>();

            for (int index = 0; index < Xs.Length; index++)
            {
                var newRow = row + Ys[index];
                var newCol = col + Xs[index];

                if (newRow >= 0 && newRow < n &&
                  newCol >= 0 && newCol < n)
                {
                    neighbours.Add(new int[] { newRow, newCol });
                }
            }

            return neighbours;
        }
    }
}
