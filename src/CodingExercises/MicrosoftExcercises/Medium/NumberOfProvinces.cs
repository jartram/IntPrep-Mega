/*
 =======================================================================================
 CHALLENGE: NumberOfProvinces
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the NumberOfProvinces problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.NumberOfProvincesTests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class NumberOfProvinces
    {
        public int FindCircleNum(int[][] M)
        {
            var count = 0;
            var visited = new HashSet<int>();

            for (int i = 0; i < M.Length; i++)
            {
                for (int j = 0; j < M[0].Length; j++)
                {
                    if (M[i][j] == 1 && !visited.Contains(i))
                    {
                        count++;
                        BFS(M, i, visited);
                    }
                }
            }

            return count;
        }

        public void BFS(int[][] graph, int node, HashSet<int> visited)
        {
            var queue = new Queue<int>();

            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var actual = queue.Dequeue();

                if (!visited.Contains(actual))
                {
                    visited.Add(actual);

                    for (int i = 0; i < graph[actual].Length; i++)
                    {
                        if (graph[actual][i] == 1)
                        {
                            queue.Enqueue(i);
                        }
                    }
                }
            }
        }
    }
}
