/*
 =======================================================================================
 CHALLENGE: MedianSorted
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MedianSorted problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.MedianSortedTests
 =======================================================================================
*/

﻿using System;

namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class MedianSorted
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }


        private int GetMax(int[] nums, int position)
        {
            if (position == 0)
            {
                return int.MinValue;
            }

            return nums[position - 1];
        }

        private int GetMin(int[] nums, int position)
        {
            if (position == nums.Length)
            {
                return int.MaxValue;
            }

            return nums[position];
        }
    }
}
