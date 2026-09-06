/*
 =======================================================================================
 CHALLENGE: PacificAtlantic
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the PacificAtlantic problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.PacificAtlanticTests
 =======================================================================================
*/

﻿using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class PacificAtlantic
    {
        public IList<IList<int>> Solve(int[][] matrix)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
        private void BFS(int[][] matrix, int i, int j, bool[,] visited)
        {
            if (!visited[i, j])
            {
                var queue = new Queue<int[]>();
                queue.Enqueue(new int[] { i, j });
                while (queue.Count > 0)
                {
                    var actual = queue.Dequeue();
                    if (!visited[actual[0], actual[1]])
                    {
                        visited[actual[0], actual[1]] = true;
                        var neighbours = GetNeighbours(matrix, actual[0], actual[1]);
                        foreach (var neighbour in neighbours)
                        {
                            queue.Enqueue(neighbour);
                        }
                    }
                }
            }
        }
        private IEnumerable<int[]> GetNeighbours(int[][] matrix, int i, int j)
        {
            IList<int[]> neighbours = new List<int[]>();
            if (i > 0 && matrix[i - 1][j] >= matrix[i][j])
            {
                neighbours.Add(new int[] { i - 1, j });
            }
            if (j > 0 && matrix[i][j - 1] >= matrix[i][j])
            {
                neighbours.Add(new int[] { i, j - 1 });
            }
            if (i < matrix.Length - 1 && matrix[i + 1][j] >= matrix[i][j])
            {
                neighbours.Add(new int[] { i + 1, j });
            }
            if (j < matrix[i].Length - 1 && matrix[i][j + 1] >= matrix[i][j])
            {
                neighbours.Add(new int[] { i, j + 1 });
            }
            return neighbours;
        }
    }
}
