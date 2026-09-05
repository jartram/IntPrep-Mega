/*
 =======================================================================================
 CHALLENGE: BuildingsWithanOceanView
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the BuildingsWithanOceanView problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.BuildingsWithanOceanViewTests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class BuildingsWithanOceanView
    {
        public int[] FindBuildings(int[] arr)
        {
            var maxRightSoFar = -1;
            var stack = new Stack<int>();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (maxRightSoFar >= arr[i])
                {
                    continue;
                }

                maxRightSoFar = arr[i];

                stack.Push(i);
            }

            var result = new int[stack.Count];
            var index = 0;

            while (stack.Count > 0)
            {
                result[index++] = stack.Pop();
            }

            return result;
        }
    }
}
