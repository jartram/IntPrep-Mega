/*
 =======================================================================================
 CHALLENGE: NumberOfProvinces
 CATEGORY: CommonExercises / Hard-Graph
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the NumberOfProvinces problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.NumberOfProvincesTests
 =======================================================================================
*/

using CodingExercises.Shared;
using System.Collections.Generic;

namespace CodingExercises.CommonExercises.Hard_Graph
{
    public class NumberOfProvinces
    {
        //Union-Find solution
        public int FindCircleNum(int[][] M)
        {

            int n = M.Length;
            var uf = new UnionFind(n);

            for (int i = 0; i < M.Length; i++)
            {
                for (int j = 0; j < M[0].Length; j++)
                {
                    if (M[i][j] == 1 && i != j) // i != j (can't be friend to oneself)
                        uf.Union(i, j);
                }
            }
            return uf.ConnectedComponents();
        }

        public int FindCircleNumBFS(int[][] isConnected)
        {
            var totalCount = 0;
            var visited = new HashSet<int>();

            for (int i = 0; i < isConnected.Length; i++)
            {
                if (!visited.Contains(i))
                {
                    totalCount++;
                    BFS(i, isConnected, visited);
                }
            }

            return totalCount;
        }

        public void BFS(int i, int[][] isConnected, HashSet<int> visited)
        {
            var queue = new Queue<int>();
            queue.Enqueue(i);

            while (queue.Count > 0)
            {
                var actual = queue.Dequeue();

                if (!visited.Contains(actual))
                {
                    visited.Add(actual);

                    for (int j = 0; j < isConnected[actual].Length; j++)
                    {
                        if (actual != j && !visited.Contains(j) && isConnected[actual][j] == 1)
                        {
                            queue.Enqueue(j);
                        }
                    }
                }
            }
        }
    }
}
