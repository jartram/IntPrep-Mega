/*
 =======================================================================================
 CHALLENGE: BiggestOfThemAll (11-arrays)
 CHAPTER: Chapter11_Arrays
 
 DESCRIPTION:
 * # Biggest of them All
 *
 * Biggest of them All is an application that can determine the biggest number in an array. Are you up for the challenge?
 *
 * Two tasks need to be accomplished:
 *
 * * Add an implementation to the method `int BiggestValue(int[] values)` in the class `ArrayAnalyzer` and make it return the value of the biggest number inside of the array `values`.
 * * Also add an implementation to the method `int BiggestIndex(int[] values)` in the class `ArrayAnalyzer` and make it return the index of the biggest number inside of the array `values`.
 *
 * In case of multiple occurrences return the first one.
 *
 * ## Expected Output
 *
 * ```text
 * Welcome to Biggest of them All ...
 * This app can determine the biggest number in an array of numbers.
 *
 * Please enters numbers separated by spaces.
 * Once finished, hit enter.
 *
 * Numbers: 1 4 -5 44 9
 *
 * The maximum number is 44 @ index 3
 *
 * Thank you for using Biggest of them All
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter11_Arrays.BiggestOfThemAll.UnitTestsArrayAnalyzer
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpPractical.Chapter11_Arrays.BiggestOfThemAll
{
    public class ArrayAnalyzer
    {
        public int BiggestValue(int[] values)
        {
            int biggest = 0;

            // TODO Determine the biggest value in the array and place the result in biggest
            // Return 0 if the array is empty (Length == 0)


            // Please don't change the code below (automatic unit tests)
            return biggest;
        }

        public int BiggestIndex(int[] values)
        {
            int indexBiggest = -1;

            // TODO Determine the index of the biggest value in the array
            // Place the resulting index in indexBiggest
            // Return -1 if the array is empty (Length == 0)
            // If multiple values exist, keep the first


            // Please don't change the code below (automatic unit tests)
            return indexBiggest;
        }
    }
}
