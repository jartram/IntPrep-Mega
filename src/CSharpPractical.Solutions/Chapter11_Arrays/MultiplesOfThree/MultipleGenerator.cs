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

using System;

namespace CSharpPractical.Chapter11_Arrays.MultiplesOfThree
{
    public class MultipleGenerator
    {
        public int[] generate()
        {
            return new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };
        }
    }
}
