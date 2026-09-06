/*
 =======================================================================================
 CHALLENGE: TextProperties (10-strings)
 CHAPTER: Chapter10_Strings
 
 DESCRIPTION:
 * # String Properties
 *
 * String Properties is an application that can analyze a user inputted string and determine some properties about that string.
 *
 * It can determine:
 *
 * * the number of vowels (`a`, `e`, ...)
 * * the number of consonants (`s`, `r`, ...)
 * * the number of digits (`1`, `2`, ...)
 * * the number of lowercase letters (`s`, `a`, ...)
 * * the number of uppercase letters (`S`, `A`, ...)
 * * the number of whitespace characters (` `, `n`, `\t`)
 *
 * Implement each of these analyses in the corresponding methods inside of the class `StringAnalyzer`.
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter10_Strings.TextProperties.UnitTestStringAnalyzer
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter10_Strings.TextProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# String Analyzer");
            Console.WriteLine("Please enter a string to analyze:");
            string text = Console.ReadLine();

            StringAnalyzer analyzer = new StringAnalyzer();
            Console.WriteLine($"\nNumber of vowels: {analyzer.NumberOfVowels(text)}");
            Console.WriteLine($"Number of consonants: {analyzer.NumberOfConsonants(text)}");
            Console.WriteLine($"Number of digits: {analyzer.NumberOfDigits(text)}");
            Console.WriteLine($"Number of lowercase letters: {analyzer.NumberOfLowercaseLetters(text)}");
            Console.WriteLine($"Number of uppercase letters: {analyzer.NumberOfUppercaseLetters(text)}");
            Console.WriteLine($"Number of whietespace characters: {analyzer.NumberOfWhitespaceCharacters(text)}");
        }
    }
}
