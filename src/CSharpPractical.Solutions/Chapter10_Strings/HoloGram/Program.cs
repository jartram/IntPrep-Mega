/*
 =======================================================================================
 CHALLENGE: HoloGram (10-strings)
 CHAPTER: Chapter10_Strings
 
 DESCRIPTION:
 * # HoloGram
 *
 * A pangram (Greek: pan gramma, "all letters") or holo-alphabetical sentence is a sentence in which all letters of the alphabet appear. The challenge is to make as short a sentence as possible that meets this condition. A very well-known example is `"The quick brown fox jumps over the lazy dog"`.
 *
 * The class `PangramChecker` allows the user to check if a sentence is a pangram by means of the method `IsPangram()`.
 *
 * Your task (also see `View => Task List` in Visual Studio):
 *
 * * Implement the method `IsPangram()` in the class `PangramChecker` so it checks if the string `text` contains all the letters of the alphabet.
 * * Make sure to convert the string to all lowercase first.
 *
 * ## Expected output
 *
 * ```text
 * Welcome to Pangram checker.
 * The most famous pangram is:
 * The quick brown fox jumps over the lazy dog
 * This application agrees that this is a pangram.
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter10_Strings.HoloGram.UnitTestPangramChecker
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter10_Strings.HoloGram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pangram checker.");

            string pangram = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine("The most famous pangram is:");
            Console.WriteLine(pangram);

            PangramChecker checker = new PangramChecker();
            bool result = checker.IsPangram(pangram + "\n");
            if (result)
            {
                Console.WriteLine("This application agrees that this is a pangram.");
            }
            else
            {
                Console.WriteLine("Sorry, there is still a bug in this app.");
            }
        }
    }
}
