/*
 =======================================================================================
 CHALLENGE: FindAllNumbersDisappearedArray
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the FindAllNumbersDisappearedArray problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.FindAllNumbersDisappearedArrayTests
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class FindAllNumbersDisappearedArray
    {
        //The idea behind this is using the values of the array as indexes and negating the values inside those indexes. After that all the positive numbers will be the missing ones.
        public IList<int> SolveNegateMethod(int[] nums)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        // The idea behind this approach is similar, using the numbes as indexes and swap until you are using the proper value or u enter on a cycle.
        // Then check if nums[i] != i + 1 > missing
        public IList<int> SolveSwapping(int[] nums)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
