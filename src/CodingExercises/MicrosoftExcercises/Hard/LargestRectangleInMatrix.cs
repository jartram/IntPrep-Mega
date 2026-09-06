/*
 =======================================================================================
 CHALLENGE: LargestRectangleInMatrix
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LargestRectangleInMatrix problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.LargestRectangleInMatrixTests
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class LargestRectangleInMatrix
    {
        public class Solution
        {
            public int MaximalRectangle(char[][] matrix)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

            private int CalculateMaximumRectangleInHistogram(int[] histogram)
            {
                var length = histogram.Length;
                var stack = new Stack<int>();

                int max = 0;
                for (int i = 0; i < length; i++)
                {
                    var current = histogram[i];
                    int h = (i == length) ? 0 : current;

                    while (stack.Count > 0 && histogram[stack.Peek()] > h)
                    {
                        int index = stack.Pop();

                        int leftBound = -1;
                        if (stack.Count > 0)
                        {
                            leftBound = stack.Peek();
                        }

                        max = Math.Max(max, histogram[index] * (i - leftBound - 1));
                    }

                    stack.Push(i);
                }

                return max;
            }
        }
    }
}
