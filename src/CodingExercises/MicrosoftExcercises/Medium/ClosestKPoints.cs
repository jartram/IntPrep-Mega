/*
 =======================================================================================
 CHALLENGE: ClosestKPoints
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ClosestKPoints problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.ClosestKPointsTests
 =======================================================================================
*/

using System;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class ClosestKPoints
    {
        public int[][] KClosest(int[][] points, int k)
        {
            return points.OrderBy(point => Math.Abs(point[0] * point[0] + point[1] * point[1])).Take(k).ToArray();
        }
    }
}
