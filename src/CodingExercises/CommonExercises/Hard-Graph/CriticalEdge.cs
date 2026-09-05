/*
 =======================================================================================
 CHALLENGE: CriticalEdge
 CATEGORY: CommonExercises / Hard-Graph
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the CriticalEdge problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.CriticalEdgeTests
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;

namespace CodingExercises.CommonExercises.Hard_Graph
{
    public class CriticalEdge
    {
        int time = 0;

        public IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public void DFS(int actualNode, int parent, int[] low, int[] disc, Dictionary<int, List<int>> graph, List<IList<int>> bridges)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
