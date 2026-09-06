/*
 =======================================================================================
 CHALLENGE: DistinctIslands
 CATEGORY: MicrosoftExcercises / Premium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the DistinctIslands problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.DistinctIslandsTests
 =======================================================================================
*/

﻿using System.Collections.Generic;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Premium
{
    public class DistinctIslands
    {
        private readonly int[] Ys = new int[] { -1, 0, 0, 1 };
        private readonly int[] Xs = new int[] { 0, -1, 1, 0 };

        public int NumDistinctIslands(int[][] grid)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private string GetDistinctIsland(int[][] grid, int i, int j)
        {
            var queue = new Queue<(int row, int col)>();
            var hashed = new StringBuilder();

            queue.Enqueue((i, j));

            while (queue.Count > 0)
            {
                var (row, col) = queue.Dequeue();

                if (grid[row][col] == 1)
                {
                    hashed.Append($"({row - i},{col - j})#");
                    grid[row][col] = '*';
                    EnqueueNeighbours(queue, row, col, grid);
                }
            }

            return hashed.ToString();
        }

        private void EnqueueNeighbours(Queue<(int, int)> queue, int row, int col, int[][] grid)
        {
            for (int i = 0; i < Xs.Length; i++)
            {
                var newRow = Ys[i] + row;
                var newCol = Xs[i] + col;

                if (newRow >= 0 && newRow < grid.Length &&
                   newCol >= 0 && newCol < grid[newRow].Length &&
                  grid[newRow][newCol] == 1)
                {
                    queue.Enqueue((newRow, newCol));
                }
            }
        }
    }
}
