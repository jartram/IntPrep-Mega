/*
 =======================================================================================
 CHALLENGE: ReplacePerformance (10-strings)
 CHAPTER: Chapter10_Strings
 
 DESCRIPTION:
 * # Replace Performance
 *
 * This application allows replacicing substrings inside of other strings.
 *
 * You can for example replace the word `hello` in the sentence `hello from all and hello to all` to `bye` resulting in `bye from all and bye to all`.
 *
 * The app needs two implementations for this functionality. One using the build in library method `Replace` and one using your own construct. You can use other methods from the library such as `Substring()` and `IndexOf()` or you can only use conditional and loop constructs.
 *
 * The replacement should be case-sensitive. In other words `Hello` and `hello` are NOT the same.
 *
 * Make sure to check the *TODO* list in the Visual Studio project.
 *
 * ## Expected Output
 *
 * ```text
 * Welcome to ReplacePerformance
 *
 * Please enter a sentence to start with:
 * pogamming becomes fun once you know and understand the basics of the pogamming language
 *
 * Now please enter a word to search for: pogamming
 * Now please enter a word to replace it with: programming
 *
 * The result is:
 * Library (took 1568 ticks): programming becomes fun once you know and understand the basics of the programming language
 * Own (took 4076 ticks): programming becomes fun once you know and understand the basics of the programming language
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter10_Strings.ReplacePerformance.UnitTestStringHelper
 =======================================================================================
*/

﻿using System;
using System.Diagnostics;

namespace CSharpPractical.Chapter10_Strings.ReplacePerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ReplacePerformance");
            Console.WriteLine("\nPlease enter a sentence to start with:");
            string text = Console.ReadLine();

            Console.Write("\nNow please enter a word to search for: ");
            string wordToReplace = Console.ReadLine();

            Console.Write("Now please enter a word to replace it with: ");
            string replacement = Console.ReadLine();

            StringHelper stringhelper = new StringHelper();

            Stopwatch watch = new Stopwatch();

            watch.Start();
            string alteredTextLib = stringhelper.ReplaceUsingLibrary(text, wordToReplace, replacement);
            watch.Stop();
            long libraryTicks = watch.ElapsedTicks;

            watch.Restart();
            string alteredTextOwn = stringhelper.ReplaceUsingOwnImplementation(text, wordToReplace, replacement);
            watch.Stop();
            long ownImplementationTicks = watch.ElapsedTicks;

            Console.WriteLine("\nThe result is:");
            Console.WriteLine($"Library (took {libraryTicks} ticks): {alteredTextLib}");
            Console.WriteLine($"Own (took {ownImplementationTicks} ticks): {alteredTextOwn}");
        }
    }
}
