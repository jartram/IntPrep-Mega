/*
 =======================================================================================
 CHALLENGE: StringsToNumbers (11-arrays)
 CHAPTER: Chapter11_Arrays
 
 DESCRIPTION:
 * # Strings to Numbers
 *
 * Strings to numbers allows the conversion of user inputted strings to an array of numbers.
 *
 * Implement the method `int[] ConvertToIntegers(string[] stringValues)` in `StringArrayConverter` so it creates a new array of integers, the same size of the input array `stringValues`. it should then convert each string value to an integer and store it in `numbers`.
 *
 * ## Expected Output
 *
 * ```text
 * Welcome to Strings to Numbers ...
 * This app can convert your input to an array of integers.
 *
 * Please enters numbers separated by spaces.
 * Once finished, hit enter.
 *
 * Numbers: 1 2 3
 *
 * After a nice conversion:
 * 1
 * 2
 * 3
 *
 * Thank you for using Strings to Numbers
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter11_Arrays.StringsToNumbers.UnitTestsStringArrayConverter
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter11_Arrays.StringsToNumbers
{
    public class StringArrayConverter
    {
        public int[] ConvertToIntegers(string[] stringValues)
        {
            // TODO Create an array of integers with the same size as the stringValues array
            int[] numbers = null;

            // TODO Convert each string in stringValues to an integer and store the result in numbers

            // Please don't change the code below (automatic unit tests)
            return numbers;
        }
    }
}
