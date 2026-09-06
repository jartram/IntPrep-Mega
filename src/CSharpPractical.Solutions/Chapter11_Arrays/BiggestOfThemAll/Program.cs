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
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter11_Arrays.BiggestOfThemAll.UnitTestsArrayAnalyzer
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter11_Arrays.BiggestOfThemAll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Biggest of them All ...");
            Console.WriteLine("This app can determine the biggest number in an array of numbers.");

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
            int[] values = new int[inputtedNumberStrings.Length];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = Convert.ToInt32(inputtedNumberStrings[i]);
            }

            // Determine the maximum number
            ArrayAnalyzer analyzer = new ArrayAnalyzer();
            int max = analyzer.BiggestValue(values);
            int maxIndex = analyzer.BiggestIndex(values);

            Console.WriteLine($"\nThe maximum number is {max} @ index {maxIndex}");

            Console.WriteLine("\nThank you for using Biggest of them All");
        }
    }
}
