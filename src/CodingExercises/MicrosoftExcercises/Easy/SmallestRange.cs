/*
 =======================================================================================
 CHALLENGE: SmallestRange
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the SmallestRange problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.SmallestRangeTests
 =======================================================================================
*/

using System;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class SmallestRange
    {
        public int SmallestRangeI(int[] A, int k)
        {
            var min = A[0];
            var max = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                min = Math.Min(min, A[i]);
                max = Math.Max(max, A[i]);
            }

            return Math.Max(0, (max - k) - (min + k));
        }
    }
}
