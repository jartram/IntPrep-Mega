/*
 =======================================================================================
 CHALLENGE: TossADieToYourWitcher (07-methods)
 CHAPTER: Chapter07_Methods
 
 DESCRIPTION:
 * # Toss a Die to Your Witcher
 *
 * This app simulates a die throw which can be used for boardgames. It generates a value between `0` and `6`. However the application developer forgot to actually call the method that generates the die throw.
 *
 * Fix the application by calling the method `ThrowDie` in `Main` and store the result in the variable `dieValue` which is then outputted to the terminal.
 *
 * Expected Output:
 *
 * ```text
 * Throwing a die ...
 * Cool, we threw 3
 * ```
 *
 * Ofcourse the thrown value changes everytime you run the application.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter07_Methods
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter07_Methods.TossADieToYourWitcher
{
    class Program
    {
        static int ThrowDie()
        {
            Random generator = new Random();
            return generator.Next(1, 7);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Throwing a die ...");

            // dieValue will need to be assigned the result of
            // of the ThrowDie() method
            int dieValue = 0;

            // TODO Call the ThrowDie method and store the result
            // that is returned by the method in the variable dieValue



            // Output result to terminal
            Console.WriteLine("Cool, we threw " + dieValue);
        }
    }
}
