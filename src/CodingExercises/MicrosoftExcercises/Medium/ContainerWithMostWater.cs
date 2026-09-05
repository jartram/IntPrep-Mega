/*
 =======================================================================================
 CHALLENGE: ContainerWithMostWater
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ContainerWithMostWater problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.ContainerWithMostWaterTests
 =======================================================================================
*/

using System;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var max = 0;
            var i = 0;
            var j = height.Length - 1;

            while (i < j)
            {
                var length = j - i;
                int actualHeight;

                if (height[i] == height[j])
                {
                    actualHeight = height[j];
                    j--;
                    i++;
                }
                else if (height[i] > height[j])
                {
                    actualHeight = height[j];
                    j--;
                }
                else
                {
                    actualHeight = height[i];
                    i++;
                }

                max = Math.Max(max, length * actualHeight);
            }

            return max;
        }
    }
}
