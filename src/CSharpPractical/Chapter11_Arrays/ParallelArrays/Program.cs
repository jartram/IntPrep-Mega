/*
 =======================================================================================
 CHALLENGE: ParallelArrays (11-arrays)
 CHAPTER: Chapter11_Arrays
 
 DESCRIPTION:
 * # Parallel Arrays
 *
 * Jantje is working on a C# project for school where he has to do quite a few operations with arrays. He quickly decides to create a new class with a number of methods that help him with these tasks.
 *
 * For this task he creates the class `ArrayHelper` with the following methods:
 *
 * * `CountDifferentFrom(elements, value): int`: this method counts the number of elements in the array that are different from `value`.
 * * `SumByElements(int[] first, int[] second): int[]`: this method sums the elements in the arrays in pairs and stores the result in a new array. In other words, the resulting array should contain the sum of the elements of the arrays `first` and `second` on the same index. You can assume that both argument arrays are of the same size.
 * * `DoubleInSize(numbers): int[]`: this method creates a new array with a size twice that of `number`. It then copies the elements from `numbers` to the new array. The result of this method is a reference to this new array. The extra elements in the new array should be initialized to `0`.
 *
 * The `Main()` method already contains a small demo application. Feel free to change it to your liking.
 *
 * ## Expected output
 *
 * ```text
 * Welcome to Parallel Arrays - A simple array helper ...
 *
 * Let's make the sum of following arrays:
 * > 123,34,54,34
 * > 12,756,43,56
 *
 * Sum:
 * > 135,790,97,90
 *
 * The first array contains 2 numbers different from 34
 *
 * Let's double the second array in size:
 * > 12,756,43,56,0,0,0,0
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter11_Arrays.ParallelArrays.UnitTestArrayHelper
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter11_Arrays.ParallelArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Parallel Arrays - A simple array helper ...\n");

            Console.WriteLine("Let's make the sum of following arrays:");
            int[] first = { 123, 34, 54, 34 };
            int[] second = { 12, 756, 43, 56 };
            int[] result = ArrayHelper.SumByElements(first, second);

            Console.WriteLine($"> { String.Join(',', first) }");
            Console.WriteLine($"> { String.Join(',', second) }");
            Console.WriteLine("\nSum:");
            Console.WriteLine($"> { String.Join(',', result) }");

            Console.WriteLine($"\nThe first array contains {ArrayHelper.CountDifferentFrom(first, 34)} numbers" +
                $" different from 34");

            Console.WriteLine("\nLet's double the second array in size:");
            second = ArrayHelper.DoubleInSize(second);
            Console.WriteLine($"> { String.Join(',', second) }");
        }
    }
}
