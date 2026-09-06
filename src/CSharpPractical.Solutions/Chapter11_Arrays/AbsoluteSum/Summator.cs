/*
 =======================================================================================
 CHALLENGE: AbsoluteSum (11-arrays)
 CHAPTER: Chapter11_Arrays
 
 DESCRIPTION:
 * # Absolute Sum
 *
 * Absolute Sum is a small application that can determine the sum of the absolute values of an array of integers.
 *
 * Your task (also see `View => Task List` in Visual Studio):
 *
 * * Implement the method `Sum()` in the class `Summator` so it iterates over the array `values` and determines the sum of the absolute values.
 * * If `values` does not contain any elements (`Length` is `0`), then the method should return the value `0`.
 *
 * ## Expected Output
 *
 * ```text
 * Welcome to Summator. Your absolute truth to summation.
 *
 * The sum of 1 2 3 4 5 is 15
 *
 * Thank you for using our app.
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter11_Arrays.AbsoluteSum.UnitTest1
 =======================================================================================
*/

using System;
using System.Linq;

namespace CSharpPractical.Chapter11_Arrays.AbsoluteSum
{
    public class Summator
    {
        public int Sum(int[] numbers)
        {
            return numbers.Sum(Math.Abs);
        }
    }
}
