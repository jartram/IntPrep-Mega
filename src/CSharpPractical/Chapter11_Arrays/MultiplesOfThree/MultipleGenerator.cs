/*
 =======================================================================================
 CHALLENGE: MultiplesOfThree (11-arrays)
 CHAPTER: Chapter11_Arrays
 
 DESCRIPTION:
 * # Multiples of Three
 *
 * Multiples of Three is a small application that can output the multiples of the number 3. Simple but effective.
 *
 * Implement the method `generate()` in `MultipleGenerator` so it generates the array of integers.
 *
 * ## Expected Output
 *
 * ```text
 * Welcome to Multiples of Three ...
 * This app prints out the first 10 multiples of three
 *
 * List of multiples:
 * 3 6 9 12 15 18 21 24 27 30
 *
 * Thank you for using Multiples of Three
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter11_Arrays.MultiplesOfThree.UnitTestsMultipleGenerator
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter11_Arrays.MultiplesOfThree
{
    public class MultipleGenerator
    {
        public int[] generate()
        {
            // TODO - Create an array of 10 integers (remove the null assignment)
            int[] multiples = null;

            // TODO - Fill the array with the first 10 multiples of 3. Start with 3 itself
            // So: 3 6 9 ...

            // Please don't change the code below (automatic unit tests)
            return multiples;
        }
    }
}
