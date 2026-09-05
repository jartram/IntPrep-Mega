/*
 =======================================================================================
 CHALLENGE: SeriesOfSquares (09-loops)
 CHAPTER: Chapter09_Loops
 
 DESCRIPTION:
 * # Series of Squares
 *
 * Many special sets of numbers are defined in mathematics. The most known is probably the Fibonacci sequence.
 *
 * A sequence is defined as the sum of an infinite sequence of numbers.
 *
 *
 * <!-- Latex: a_1 + a_2 + a_3 + ... = \sum_{i=0}^{\infty} a_i -->
 *
 * Some finite series can be easily calculated using a formula. You do not always have to make the full sum.
 *
 * If we define the finite series of squares as follows:
 *
 *
 * <!-- Latex: 1^2 + 2^2 + 3^2 + ... + n^2 = \sum_{i=0}^{n} i^2 -->
 *
 * Then you could calculate the sum as follows:
 *
 *
 * <!-- Latex: 1^2 + 2^2 + 3^2 + ... + n^2 = \frac{n (n + 1) (2n + 1)}{6} -->
 *
 * Of course we have to test this to see if this is correct.
 *
 * Implement the following methods in the class `SquaredSeries`:
 *
 * * `SeriesSum(int n)`: calculate the sum of the series of squares by adding the squares of the first `n` (inclusive) natural numbers. Start from `1`.
 * * `CalculateSumSeries(int n)`: find the sum of the series of squares by applying the above formula.
 *
 * The `Main()` method already contains a small demo application. Feel free to change it to your liking.
 *
 * ## Expected Output
 *
 * ```text
 * Welcome to Series of Square
 *
 * Let's determine the sum of the following series:
 * 1^2 + 2^2 + 3^2 + 4^2 + 5^2
 *
 * - Using summation: 55
 * - Using formula: 55
 *
 * Super! The formula seems to be correct.
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter09_Loops.SeriesOfSquares.UnitTestSquaredSeries
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter09_Loops.SeriesOfSquares
{
    public class SquaredSeries
    {
        public static int SeriesSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += i * i;
            return sum;
        }

        public static int CalculateSumSeries(int n) => SeriesSum(n);
    }
}
