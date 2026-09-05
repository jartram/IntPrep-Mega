/*
 =======================================================================================
 CHALLENGE: ContainerWithMostWater
 CATEGORY: CommonExercises / Hard-Array
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ContainerWithMostWater problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.ContainerWithMostWaterTests
 =======================================================================================
*/

using System;

namespace CodingExercises.CommonExercises.Hard_Array
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var maxArea = 0;
            var i = 0;
            var j = height.Length - 1;

            while (i < j)
            {
                var hI = height[i];
                var hJ = height[j];

                maxArea = Math.Max(maxArea, Math.Min(hI, hJ) * (j - i));

                if (hI < hJ)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return maxArea;
        }
    }
}
