/*
 =======================================================================================
 CHALLENGE: IntersectionOfTwoList
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the IntersectionOfTwoList problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.IntersectionOfTwoListTests
 =======================================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class IntersectionOfTwoList
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                var aux = nums1;
                nums1 = nums2;
                nums2 = aux;
            }

            var hsNums1 = nums1.ToHashSet();
            var solution = new HashSet<int>();

            foreach (var num in nums2)
            {
                if (hsNums1.Contains(num))
                {
                    solution.Add(num);
                }
            }

            return solution.ToArray();
        }
    }
}
