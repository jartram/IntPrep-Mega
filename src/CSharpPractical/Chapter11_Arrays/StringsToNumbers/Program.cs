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

namespace CSharpPractical.Chapter11_Arrays.StringsToNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Strings to Numbers ...");
            Console.WriteLine("This app can convert your input to an array of integers.");

            Console.WriteLine("\nPlease enters numbers separated by spaces.");
            Console.WriteLine("Once finished, hit enter.");

            // Request all numbers from user
            string userInput;
            do
            {
                Console.Write("\nNumbers: ");
                userInput = Console.ReadLine().Trim();
            } while (userInput == "");

            // Split them into array of strings based on space (' ') between numbers
            string[] inputtedNumberStrings = userInput.Split(' ');

            // Convert array of strings to array of ints
            StringArrayConverter converter = new StringArrayConverter();
            int[] values = converter.ConvertToIntegers(inputtedNumberStrings);

            // Output values
            Console.WriteLine("\nAfter a nice conversion:");
            if (values != null)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    Console.WriteLine($"{values[i] }");
                }
            }

            Console.WriteLine("\nThank you for using Strings to Numbers");
        }
    }
}
