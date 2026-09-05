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
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter11_Arrays.TheSumOfAllNumbers.UnitTestsSumOfIntegers
 =======================================================================================
*/

﻿using System;
using System.Linq;

namespace CSharpPractical.Chapter11_Arrays.TheSumOfAllNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Sum of All Numbers ...");
            Console.WriteLine("This app can calculate the sum of an array of integers.");

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
            int[] values = new int[inputtedNumberStrings.Length];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = Convert.ToInt32(inputtedNumberStrings[i]);
            }

            // Calculate the sum of integers
            SumOfIntegers summator = new SumOfIntegers();
            int sum = summator.CalculateSum(values);

            Console.WriteLine($"\nThe sum equals {sum}");

            Console.WriteLine("\nThank you for using The Sum of All Numbers");
        }
    }
}
