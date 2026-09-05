/*
 =======================================================================================
 CHALLENGE: TurnTheTables (11-arrays)
 CHAPTER: Chapter11_Arrays
 
 DESCRIPTION:
 * # Turn the Tables
 *
 * Turn the Tables is a small App to teach children the tables of multiplications. Just input a multiplier and it will output the first 10 values.
 *
 * However, there is a small catch. The actual method `int[] Multiply(int[] left, int[] right)` that needs to implement the multiplication is missing its code. Can you retrieve it?
 *
 * ## Expected Output
 *
 * ```text
 * Welcome to Turn the Tables ...
 * This app can calculate a table of multiplications.
 *
 * Please enter your desired multiplier: 7
 * Lets output an example:
 *
 * The table of multiplication for the number 7:
 * 0 x 7 = 0
 * 1 x 7 = 7
 * 2 x 7 = 14
 * 3 x 7 = 21
 * 4 x 7 = 28
 * 5 x 7 = 35
 * 6 x 7 = 42
 * 7 x 7 = 49
 * 8 x 7 = 56
 * 9 x 7 = 63
 *
 * Thank you for using Turn the Tables
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter11_Arrays.TurnTheTables.UnitTestsArrayMultiplier
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter11_Arrays.TurnTheTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Turn the Tables ...");
            Console.WriteLine("This app can calculate a table of multiplications.");
            Console.Write("\nPlease enter your desired multiplier: ");
            int multiplier = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lets output an example:");

            int[] indices = new int[10];
            for (int i = 0; i < indices.Length; i++)
            {
                indices[i] = i;
            }

            int[] multipliers = new int[indices.Length];
            for (int i = 0; i < multipliers.Length; i++)
            {
                multipliers[i] = multiplier;
            }

            ArrayMultiplier arrayMultiplier = new ArrayMultiplier();
            int[] tableOfMultiplications = arrayMultiplier.Multiply(indices, multipliers);

            // Outputting result
            Console.WriteLine($"\nThe table of multiplication for the number {multiplier}:");
            if (tableOfMultiplications != null)
            {
                for (int i = 0; i < tableOfMultiplications.Length; i++)
                {
                    Console.WriteLine($"{indices[i]} x {multipliers[i]} = {tableOfMultiplications[i]}");
                }
            }

            Console.WriteLine("\nThank you for using Turn the Tables");
        }
    }
}
