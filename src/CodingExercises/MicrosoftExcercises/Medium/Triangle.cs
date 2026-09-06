/*
 =======================================================================================
 CHALLENGE: Triangle
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Triangle problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.TriangleTests
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class Triangle
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private int MinimumTotal(IList<IList<int>> triangle, int row, int col, Dictionary<string, int> cache)
        {
            var key = $"{row}#{col}";

            if (cache.ContainsKey(key))
            {
                return cache[key];
            }

            if (row == triangle.Count - 1)
            {
                return triangle[row][col];
            }

            cache.Add(key, triangle[row][col] + Math.Min(MinimumTotal(triangle, row + 1, col, cache),
                                                         MinimumTotal(triangle, row + 1, col + 1, cache)));

            return cache[key];
        }
    }
}
