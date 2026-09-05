/*
 =======================================================================================
 CHALLENGE: CourseSchedule
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the CourseSchedule problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.CourseScheduleTests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class CourseSchedule
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            if (prerequisites.Length < 2)
            {
                return true;
            }

            var degrees = new int[numCourses];
            var topoSort = new List<int>();
            var graph = new Dictionary<int, List<int>>();
            var queue = new Queue<int>();

            foreach (var pre in prerequisites)
            {
                if (!graph.ContainsKey(pre[0]))
                {
                    graph.Add(pre[0], new List<int>());
                }

                if (!graph.ContainsKey(pre[1]))
                {
                    graph.Add(pre[1], new List<int>());
                }

                graph[pre[0]].Add(pre[1]);
                graph[pre[1]].Add(pre[0]);
                degrees[pre[1]]++;
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

                if (graph.ContainsKey(actual))
                {
                    foreach (var neighbour in graph[actual])
                    {
                        degrees[neighbour]--;

                        if (degrees[neighbour] == 0)
                        {
                            queue.Enqueue(neighbour);
                        }
                    }
                }
            }

            return topoSort.Count == numCourses;
        }
    }
}
