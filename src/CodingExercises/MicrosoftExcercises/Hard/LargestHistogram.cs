/*
 =======================================================================================
 CHALLENGE: LargestHistogram
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LargestHistogram problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.LargestHistogramTests
 =======================================================================================
*/

using System;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class LargestHistogram
    {
        public int Solve(int[] hist)
        {
            var max = 0;
            var stack = new Stack<int>();

            for (int i = 0; i <= hist.Length; i++)
            {
                var bar = i == hist.Length ? 0 : hist[i];

                while (stack.Count > 0 && hist[stack.Peek()] >= bar)
                {
                    var prevHeight = hist[stack.Pop()];
                    var leftBount = stack.Count > 0 ? stack.Pop() : -1;
                    var diff = i - leftBount - 1;

                    max = Math.Max(max, prevHeight * diff);
                }

                stack.Push(i);
            }

            return max;
        }
    }
}
