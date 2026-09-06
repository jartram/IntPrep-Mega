/*
 =======================================================================================
 CHALLENGE: GraphNode
 CATEGORY: Shared
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the GraphNode problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.Shared.GraphNodeTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.Shared
{
    public class GraphNode
    {
        public int val;
        public IList<GraphNode> neighbors;

        public GraphNode()
        {
            val = 0;
            neighbors = new List<GraphNode>();
        }

        public GraphNode(int _val)
        {
            val = _val;
            neighbors = new List<GraphNode>();
        }

        public GraphNode(int _val, List<GraphNode> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
}
