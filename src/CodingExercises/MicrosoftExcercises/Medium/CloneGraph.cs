/*
 =======================================================================================
 CHALLENGE: CloneGraph
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the CloneGraph problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.CloneGraphTests
 =======================================================================================
*/

using CodingExercises.Shared;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class CloneGraph
    {
        public GraphNode Solve(GraphNode node)
        {
            if (node == null)
            {
                return node;
            }

            var dict = new Dictionary<GraphNode, GraphNode>();
            var queue = new Queue<GraphNode>();

            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var actual = queue.Dequeue();

                if (!dict.ContainsKey(actual))
                {
                    dict.Add(actual, new GraphNode(actual.val));

                    foreach (var child in actual.neighbors)
                    {
                        if (!dict.ContainsKey(child))
                        {
                            queue.Enqueue(child);
                        }
                    }
                }
            }

            foreach (var actualGraphNode in dict.Keys)
            {
                foreach (var child in actualGraphNode.neighbors)
                {
                    dict[actualGraphNode].neighbors.Add(dict[child]);
                }
            }

            return dict[node];
        }
    }
}
