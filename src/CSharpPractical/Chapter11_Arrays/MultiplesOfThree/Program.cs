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
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter11_Arrays.MultiplesOfThree.UnitTestsMultipleGenerator
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter11_Arrays.MultiplesOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Multiples of Three ...");
            Console.WriteLine("This app prints out the first 10 multiples of three");

            MultipleGenerator generator = new MultipleGenerator();
            int[] multiples = generator.generate();

            Console.WriteLine("\nList of multiples:");
            if (multiples != null)
            {
                foreach (int multiple in multiples)
                {
                    Console.Write($"{multiple} ");
                }
            }

            Console.WriteLine("\n\nThank you for using Multiples of Three");
        }
    }
}
