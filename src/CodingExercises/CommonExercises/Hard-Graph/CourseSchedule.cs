/*
 =======================================================================================
 CHALLENGE: CourseSchedule
 CATEGORY: CommonExercises / Hard-Graph
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the CourseSchedule problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.CourseScheduleTests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.CommonExercises.Hard_Graph
{
    public class CourseSchedule
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var degrees = new int[numCourses];
            var lookup = new Dictionary<int, List<int>>();
            var queue = new Queue<int>();
            var topoSort = new List<int>();

            foreach (var edge in prerequisites)
            {
                if (!lookup.ContainsKey(edge[0]))
                {
                    lookup.Add(edge[0], new List<int>());
                }

                lookup[edge[0]].Add(edge[1]);
                degrees[edge[1]]++;
            }

            for (int i = 0; i < degrees.Length; i++)
            {
                if (degrees[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            while (queue.Count > 0)
            {
                var actual = queue.Dequeue();

                topoSort.Add(actual);

                if (lookup.ContainsKey(actual))
                {
                    foreach (var node in lookup[actual])
                    {
                        degrees[node]--;

                        if (degrees[node] == 0)
                        {
                            queue.Enqueue(node);
                        }
                    }
                }
            }

            return topoSort.Count == numCourses;
        }
    }
}
