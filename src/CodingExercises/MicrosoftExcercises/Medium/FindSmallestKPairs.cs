/*
 =======================================================================================
 CHALLENGE: FindSmallestKPairs
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the FindSmallestKPairs problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.FindSmallestKPairsTests
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class FindSmallestKPairs
    {
        public IList<IList<int>> KSmallestPairsBruteForce(int[] nums1, int[] nums2, int k)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public IList<IList<int>> KSmallestPairsUsingSet(int[] nums1, int[] nums2, int k)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public class Comparer : IComparer<(int nums1Index, int nums2Index)>
        {
            int[] nums1;
            int[] nums2;

            public Comparer(int[] nums1, int[] nums2)
            {
                this.nums1 = nums1;
                this.nums2 = nums2;
            }

            public int Compare((int nums1Index, int nums2Index) A, (int nums1Index, int nums2Index) B)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
        }
    }
}
