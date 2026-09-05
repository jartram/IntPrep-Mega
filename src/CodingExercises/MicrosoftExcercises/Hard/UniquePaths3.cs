/*
 =======================================================================================
 CHALLENGE: UniquePaths3
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the UniquePaths3 problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.UniquePaths3Tests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class UniquePaths3
    {
        public class Solution
        {

            private (int, int)[] directions = new (int, int)[]
            {
                (0, 1), (1, 0), (-1, 0), (0,-1)
            };

            public int UniquePathsIII(int[][] grid)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

            private void Backtrack((int, int) start,
                                   (int, int) dest,
                                   HashSet<(int, int)> visited,
                                   ref int total,
                                   int noObstacles,
                                   int[][] matrix)
            {
                if (start == dest)
                {
                    if (visited.Count == noObstacles)
                    {
                        total++;
                    }

                    return;
                }

                var neighbors = GetNeighbors(start, matrix);

                foreach (var neighbor in neighbors)
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);

                        Backtrack(neighbor, dest, visited, ref total, noObstacles, matrix);

                        visited.Remove(neighbor);
                    }
                }
            }

            private IList<(int, int)> GetNeighbors((int row, int col) start, int[][] matrix)
            {
                var neighbors = new List<(int, int)>();

                foreach (var (rowDirection, colDirection) in directions)
                {
                    var newRow = start.row + rowDirection;
                    var newCol = start.col + colDirection;

                    if (newRow >= 0 && newRow < matrix.Length &&
                       newCol >= 0 && newCol < matrix[newRow].Length &&
                       matrix[newRow][newCol] != -1)
                    {
                        neighbors.Add((newRow, newCol));
                    }
                }

                return neighbors;
            }
        }
    }
}
