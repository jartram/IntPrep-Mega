/*
 =======================================================================================
 CHALLENGE: MergeIntervals
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MergeIntervals problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.MergeIntervalsTests
 =======================================================================================
*/

using System;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            var result = new List<int[]>();

            Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

            int i = 0;

            while (i < intervals.Length)
            {
                var start = intervals[i][0];
                var end = intervals[i][1];
                var changed = false;

                while (i < intervals.Length && intervals[i][0] <= end)
                {
                    end = Math.Max(end, intervals[i][1]);
                    i++;
                    changed = true;
                }

                result.Add(new int[] { start, end });

                if (!changed)
                {
                    i++;
                }
            }


            return result.ToArray();
        }
    }
}
