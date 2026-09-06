/*
 =======================================================================================
 CHALLENGE: NumberManipulator (09-loops)
 CHAPTER: Chapter09_Loops
 
 DESCRIPTION:
 * # Number Manipulator
 *
 * Number Manipulator is a small app that allows us to manipulate numbers on a digit level.
 *
 * The app provides the following methods in the class `Manipulator`:
 *
 * * `Reverse(int value)`: reverses numbers, eg converting `12345` to `54321`. You simply reverse the number. When a number ends in `0`(s), you may ignore them for the result.
 * * `Complement(int value)`: calculate he complement of numbers, eg convert `12345` to `87654`. The value is per digit subtracted from `9`.
 * * `DigitSum(int value)`: determine the sum of the individual digits. The digit sum of `12345` is `15.
 *
 * All methodes can be realized by approaching the number digit by digit. In other words, by working with division by `10` and module `10`.
 *
 * The `Main()` method already contains a small demo application. Feel free to change it to your liking.
 *
 * ## Expected Output
 *
 * ```text
 * Welcome to Number Manipulator
 *
 * Let's reverse some numbers:
 *  The inverted value of 123 is 321
 *  The inverted value of 9200 is 29
 *  The inverted value of 111 is 111
 *  The inverted value of 0 is 0
 *
 * Let's complement some numbers:
 *  The complement value of 123 is 876
 *  The complement value of 9200 is 799
 *  The complement value of 111 is 888
 *  The complement value of 8 is 1
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter09_Loops.NumberManipulator.UnitTestManipulator
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter09_Loops.NumberManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Number Manipulator\n");

            Console.WriteLine("Let's reverse some numbers: ");
            Console.WriteLine($" The inverted value of 123 is {Manipulator.Reverse(123)}");
            Console.WriteLine($" The inverted value of 9200 is {Manipulator.Reverse(9200)}");
            Console.WriteLine($" The inverted value of 111 is {Manipulator.Reverse(111)}");
            Console.WriteLine($" The inverted value of 0 is {Manipulator.Reverse(0)}");

            Console.WriteLine("\nLet's complement some numbers: ");
            Console.WriteLine($" The complement value of 123 is {Manipulator.Complement(123)}");
            Console.WriteLine($" The complement value of 9200 is {Manipulator.Complement(9200)}");
            Console.WriteLine($" The complement value of 111 is {Manipulator.Complement(111)}");
            Console.WriteLine($" The complement value of 8 is {Manipulator.Complement(8)}");

            Console.WriteLine("\nNow let's sum some digits: ");
            Console.WriteLine($" The sum of digits of 532 is {Manipulator.DigitSum(532)}");
            Console.WriteLine($" The sum of digits of 231324 is {Manipulator.DigitSum(231324)}");
            Console.WriteLine($" The sum of digits of 23 is {Manipulator.DigitSum(23)}");
            Console.WriteLine($" The sum of digits of 8 is {Manipulator.DigitSum(8)}");
        }
    }
}
