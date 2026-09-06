/*
 =======================================================================================
 CHALLENGE: SumAndDifference (07-methods)
 CHAPTER: Chapter07_Methods
 
 DESCRIPTION:
 * # Sum and Difference
 *
 * Sum and Difference is a small application that requests two numbers from the user. It than outputs both the sum and difference of the numbers.
 *
 * Your tasks:
 *
 * 1. Request two numbers from the user by calling the method `RequestNumber` twice and storing the results in the appropriate variables.
 * 2. Now call the method `Add` and pass both the variables `number1` and `number2` to the method as arguments. Store the result of the method in `sum`.
 * 3. Create a method `Subtract` that substracts a second argument from a first argument and returns the result. Now call this method in Main with `number1` and `number2`.
 *
 * Expected Output:
 *
 * ```text
 * Please enter a number: 24
 * Please enter a number: 16
 * You entered 24 and 16.
 *
 * Their sum: 40
 *
 * Their difference: 8
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter07_Methods.SumAndDifferenceTest
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter07_Methods.SumAndDifference
{
    public class Program
    {
        static int RequestNumber()
        {
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);
            return number;
        }

        internal static int Add(int first, int second)
        {
            return (first + second);
        }

        internal static int Subtract(int first, int second)
        {
            // TODO: Subtract second from first
            return 0;
        }

        // TODO Create a method Subtract that substracts
        // a second argument from a first argument and returns the result.


        static void Main(string[] args)
        {
            // TODO Request two numbers from the user:
            int number1 = 0;
            int number2 = 0;



            // Show user the inputted numbers
            Console.WriteLine("You entered " + number1 + " and " + number2 + ".");

            // TODO Call the Add method and store the result in the variable sum.
            // Make sure to pass the two numbers as arguments to the method.
            int sum = 0;



            // Result of sum
            Console.WriteLine("\nTheir sum: " + sum);

            // TODO Call the Subtract method and store the result in the variable difference.
            // Make sure to pass the two numbers as arguments to the method.
            int difference = 0;



            // Result of sum
            Console.WriteLine("\nTheir difference: " + difference);
        }
    }
}
