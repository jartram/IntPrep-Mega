/*
 =======================================================================================
 CHALLENGE: LongestIncreasingPathInMatrix
 CATEGORY: TrainExercises / DailyChallengesLC
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LongestIncreasingPathInMatrix problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.TrainExercises.LongestIncreasingPathInMatrixTests
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;

namespace CodingExercises.TrainExercises.DailyChallengesLC
{
    public class LongestIncreasingPathInMatrix
    {
        //HARD Time limit exceed
        public int[,] cache;

        public int LongestIncreasingPath(int[][] matrix)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private int DFS(int[][] matrix, int i, int j)
        {
            if (cache[i, j] > 0)
            {
                return cache[i, j];
            }

            var neighbours = CalculateNeighbours(matrix, i, j);

            int max = 0;

            foreach (var neighbour in neighbours)
            {
                var longest = DFS(matrix, neighbour[0], neighbour[1]);
                max = Math.Max(max, longest);
            }

            cache[i, j] = max + 1;

            return cache[i, j];
        }

        private List<int[]> CalculateNeighbours(int[][] matrix, int i, int j)
        {
            List<int[]> list = new List<int[]>();

            if (i > 0 && matrix[i - 1][j] > matrix[i][j])
            {
                list.Add(new int[] { i - 1, j });
            }

            if (j > 0 && matrix[i][j - 1] > matrix[i][j])
            {
                list.Add(new int[] { i, j - 1 });
            }

            if (i < matrix.Length - 1 && matrix[i + 1][j] > matrix[i][j])
            {
                list.Add(new int[] { i + 1, j });
            }

            if (j < matrix[i].Length - 1 && matrix[i][j + 1] > matrix[i][j])
            {
                list.Add(new int[] { i, j + 1 });
            }

            return list;
        }
    }
}
