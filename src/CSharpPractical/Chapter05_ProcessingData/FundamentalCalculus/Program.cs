/*
 =======================================================================================
 CHALLENGE: FundamentalCalculus (05-processing-data)
 CHAPTER: Chapter05_ProcessingData
 
 DESCRIPTION:
 * # Fundamental Calculus
 *
 * This app models a basic calculator. Implement all the methods of the `Calculator` class so they return the correct values.
 *
 * The `Add()` method has already been implemented to provide you with an example.
 *
 * You can also extend the `Main()` with more code to test your implementation.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter05_ProcessingData.FundamentalCalculus.UnitTestCalculator
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter05_ProcessingData.FundamentalCalculus
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Welcome to Fundamental Calculus\n");

            Console.WriteLine($"3 + 5 = {calculator.Add(3, 5)}");
            Console.WriteLine($"3 + (-5) = {calculator.Add(3, -5)}");

            Console.WriteLine($"7 - 2 = {calculator.Subtract(7, 2)}");
            Console.WriteLine($"7 - (-2) = {calculator.Subtract(7, -2)}");

            Console.WriteLine($"4 * 6 = {calculator.Multiply(4, 6)}");
            Console.WriteLine($"4 * (-6) = {calculator.Multiply(4, -6)}");

            // TODO: Add further examples yourself
        }
    }
}
