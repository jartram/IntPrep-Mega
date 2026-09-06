/*
 =======================================================================================
 CHALLENGE: LongestIncreasingPathInMatrix
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LongestIncreasingPathInMatrix problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.LongestIncreasingPathInMatrixTests
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class LongestIncreasingPathInMatrix
    {
        private readonly int[] Ys = new int[] { -1, 0, 0, 1 };
        private readonly int[] Xs = new int[] { 0, -1, 1, 0 };

        public int LongestIncreasingPath(int[][] matrix)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private int LongestIncreasingPath(int[][] matrix, int row, int col, Dictionary<string, int> memo)
        {
            var key = $"{row}#{col}";

            if (memo.ContainsKey(key))
            {
                return memo[key];
            }

            var greaters = CalculateGreaters(matrix, row, col);

            if (greaters.Count == 0)
            {
                return 1;
            }

            var max = 0;

            foreach (var greater in greaters)
            {
                max = Math.Max(max, LongestIncreasingPath(matrix, greater[0], greater[1], memo) + 1);
            }

            memo.Add(key, max);

            return max;
        }

        public IList<int[]> CalculateGreaters(int[][] matrix, int row, int col)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
