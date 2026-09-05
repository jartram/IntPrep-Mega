/*
 =======================================================================================
 CHALLENGE: TheSumOfAllNumbers (11-arrays)
 CHAPTER: Chapter11_Arrays
 
 DESCRIPTION:
 * # The Sum of All Numbers
 *
 * The Sum of All Numbers is a small application that can determine the sum of an array of integers inputted by the user.
 *
 * Implement the method `int CalculateSum(int[] numbers)` in `SumOfIntegers` so it calculates the sum from the array of integers. Use a for-loop construct to do this.
 *
 * ## Expected Output
 *
 * ```text
 * Welcome to The Sum of All Numbers ...
 * This app can calculate the sum of an array of integers.
 *
 * Please enters numbers separated by spaces.
 * Once finished, hit enter.
 *
 * Numbers: 9 -5 12 0 13 100
 *
 * The sum equals 129
 *
 * Thank you for using The Sum of All Numbers
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter11_Arrays.TheSumOfAllNumbers.UnitTestsSumOfIntegers
 =======================================================================================
*/

using System;
using System.Linq;

namespace CSharpPractical.Chapter11_Arrays.TheSumOfAllNumbers
{
    public class SumOfIntegers
    {
        public int CalculateSum(int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
