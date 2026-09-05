/*
 =======================================================================================
 CHALLENGE: FindClosestElements
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the FindClosestElements problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.FindClosestElementsTests
 =======================================================================================
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class FindClosestElements
    {
        public IList<int> Solve(int[] arr, int k, int x)
        {
            // Initialize binary search bounds
            int low = 0;
            int high = arr.Length - k;

            while (low < high)
            {
                var mid = low + (high - low) / 2;

                if (x - arr[mid] > arr[mid + k] - x)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }

            var result = new List<int>();

            for (int i = low; i < low + k; i++)
            {
                result.Add(arr[i]);
            }

            return result;
        }
    }
}
