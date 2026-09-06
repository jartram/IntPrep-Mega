/*
 =======================================================================================
 CHALLENGE: Itinerary
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Itinerary problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.ItineraryTests
 =======================================================================================
*/

﻿using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class Itinerary
    {
        //greedy + backtracking
        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private void Backtrack(int totalTickets,
                               Dictionary<string, List<string>> graph,
                               string start,
                               LinkedList<string> current,
                               List<string> result)
        {
            if (totalTickets == 0)
            {
                foreach (var item in current)
                {
                    result.Add(item);
                }

                return;
            }

            if (graph.ContainsKey(start))
            {
                foreach (var edge in graph[start].ToList())
                {
                    current.AddLast(edge);
                    graph[start].Remove(edge);

                    Backtrack(totalTickets - 1, graph, edge, current, result);

                    current.RemoveLast();
                    graph[start].Add(edge);

                    if (result.Count > 0)
                    {
                        return;
                    }
                }
            }
        }

        //magic stupid dfs
        public IList<string> FindItineraryDFS(IList<IList<string>> tickets)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private void DFS(string start, LinkedList<string> result, Dictionary<string, List<string>> graph)
        {
            if (graph.ContainsKey(start))
            {
                var list = graph[start];

                while (list.Count > 0)
                {
                    var destination = list.ElementAt(0);
                    list.RemoveAt(0);

                    DFS(destination, result, graph);
                }
            }

            result.AddFirst(start);
        }

        private Dictionary<string, List<string>> CreateGraph(IList<IList<string>> tickets)
        {
            var graph = new Dictionary<string, List<string>>();

            foreach (var ticket in tickets)
            {
                var start = ticket[0];
                var end = ticket[1];

                if (!graph.ContainsKey(start))
                {
                    graph.Add(start, new List<string>());
                }

                graph[start].Add(end);
            }

            foreach (var list in graph.Values)
            {
                list.Sort();
            }

            return graph;
        }
    }
}
