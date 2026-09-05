/*
 =======================================================================================
 CHALLENGE: MaximalNetworkRank
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MaximalNetworkRank problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.MaximalNetworkRankTests
 =======================================================================================
*/

using System;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class MaximalNetworkRank
    {
        public int Solve(int n, int[][] roads)
        {
            var connected = new bool[n, n];
            var outdegrees = new int[n];
            var max = 0;

            foreach (var road in roads)
            {
                var u = road[0];
                var v = road[1];

                connected[u, v] = true;
                connected[v, u] = true;

                outdegrees[u]++;
                outdegrees[v]++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (connected[i, j])
                    {
                        max = Math.Max(max, outdegrees[i] + outdegrees[j] - 1);
                    }
                    else
                    {
                        max = Math.Max(max, outdegrees[i] + outdegrees[j]);
                    }
                }
            }

            return max;
        }
    }
}
