/*
 =======================================================================================
 CHALLENGE: AllPathFromOriginToEnd
 CATEGORY: CommonExercises
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the AllPathFromOriginToEnd problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.AllPathFromOriginToEndTests
 =======================================================================================
*/

using System.Linq;
﻿using System.Collections.Generic;

namespace CodingExercises.CommonExercises
{
    public class AllPathFromOriginToEnd
    {
        public class Solution
        {
            public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

            private void Backtrack(int node, int[][] graph, List<int> current, IList<IList<int>> result)
            {
                if (node == graph.Length - 1)
                {
                    result.Add(current.ToList());
                }

                for (int i = 0; i < graph[node].Length; i++)
                {
                    if (graph[node][i] != -1)
                    {
                        var newNode = graph[node][i];
                        graph[node][i] = -1;
                        current.Add(newNode);
                        Backtrack(newNode, graph, current, result);
                        current.RemoveAt(current.Count - 1);
                        graph[node][i] = newNode;
                    }
                }
            }
        }
    }
}
