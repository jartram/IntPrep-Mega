using System;
using System.Linq;

namespace CodingExercises.Solutions.MicrosoftExcercises.Medium
{
    public class ClosestKPoints
    {
        public int[][] KClosest(int[][] points, int k)
        {
            return points.OrderBy(point => Math.Abs(point[0] * point[0] + point[1] * point[1])).Take(k).ToArray();
        }
    }
}
