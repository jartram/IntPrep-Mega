/*
 =======================================================================================
 CHALLENGE: ThirdNumber
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ThirdNumber problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.ThirdNumberTests
 =======================================================================================
*/

﻿using System;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class ThirdNumber
    {
        public int ThirdMax(int[] nums)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private int ThirdMax(int[] nums, int left, int right)
        {
            var position = partition(nums, left, right);

            if (position == 2)
            {
                return nums[position];
            }
            else if (position < 2)
            {
                return ThirdMax(nums, position + 1, right);
            }
            else
            {
                return ThirdMax(nums, left, position - 1);
            }
        }

        private int partition(int[] values, int left, int right)
        {
            int pivotValue = values[right];
            int pivotLocation = left;

            for (int i = left; i < right; i++)
            {
                if (pivotValue < values[i])
                {
                    Swap(pivotLocation, i, values);
                    pivotLocation++;
                }
            }

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
