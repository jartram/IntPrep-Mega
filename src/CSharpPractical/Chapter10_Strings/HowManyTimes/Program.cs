/*
 =======================================================================================
 CHALLENGE: HowManyTimes (10-strings)
 CHAPTER: Chapter10_Strings
 
 DESCRIPTION:
 * # How Many Times
 *
 * This app allows a user to enter a text and a word. The app will search the text for the word and count how many times the word appears in the text.
 *
 * Well at least that's the idea, but the functionality is not there yet.
 *
 * Implement the method `SearchAndCount(string text, string word)` in the class `StringFinder` to search and count the number of occurrences of the string `word` inside the `text`.
 *
 * The implementation should treat lowercase and uppercase versions the same.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter10_Strings.HowManyTimes.UnitTestStringFinder
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter10_Strings.HowManyTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to How Many Times ...");
            Console.WriteLine("This app can determine the number of occurrences of a word inside a text.");
            Console.WriteLine("Please enter a text:");
            string text = Console.ReadLine();
            Console.Write("Please enter a word to search for: ");
            string word = Console.ReadLine();

            StringFinder finder = new StringFinder();

            int times = finder.SearchAndCount(text, word);
            Console.WriteLine($"\nThe word \"{word}\" was found {times} times inside the text");
        }
    }
}
