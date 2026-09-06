/*
 =======================================================================================
 CHALLENGE: WordsEverywhere (10-strings)
 CHAPTER: Chapter10_Strings
 
 DESCRIPTION:
 * # Words Everywhere
 *
 * Words Everywhere is a simple and user friendly app that counts the number of words in a text.
 *
 * Implement the method `CountWords(string text)` in the class `WordCounter` so it returns the number of words in the given text.
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter10_Strings.WordsEverywhere.UnitTestWordCounter
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter10_Strings.WordsEverywhere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Word Counter App.");
            Console.WriteLine("Please enter a text. This app will then count the number of words.");
            Console.WriteLine("Your text:");
            string text = Console.ReadLine();

            WordCounter counter = new WordCounter();

            Console.WriteLine($"\nThe text contains {counter.CountWords(text)} words");
        }
    }
}
