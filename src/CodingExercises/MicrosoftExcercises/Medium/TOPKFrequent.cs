/*
 =======================================================================================
 CHALLENGE: TOPKFrequent
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the TOPKFrequent problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.TOPKFrequentTests
 =======================================================================================
*/

﻿using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class TOPKFrequent
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private int[] TopKFrequent(int[] values, int[] keys, int k, int left, int right)
        {
            var pivotPosition = partition(values, k, left, right, keys);

            if (pivotPosition == values.Length - k)
            {
                return keys.Skip(pivotPosition).Take(k).ToArray();
            }
            else if (pivotPosition < values.Length - k)
            {
                return TopKFrequent(values, keys, k, pivotPosition + 1, right);
            }
            else
            {
                return TopKFrequent(values, keys, k, left, pivotPosition - 1);
            }
        }

        private int partition(int[] values, int k, int left, int right, int[] keys)
        {
            int pivotValue = values[right];
            int pivotLocation = left;

            for (int i = left; i < right; i++)
            {
                if (pivotValue > values[i])
                {
                    Swap(pivotLocation, i, keys);
                    Swap(pivotLocation, i, values);
                    pivotLocation++;
                }
            }

            Swap(pivotLocation, right, keys);
            Swap(pivotLocation, right, values);

            return pivotLocation;
        }

        private void Swap(int i, int j, int[] arr)
        {
            int aux = arr[i];
            arr[i] = arr[j];
            arr[j] = aux;
        }
    }
}
