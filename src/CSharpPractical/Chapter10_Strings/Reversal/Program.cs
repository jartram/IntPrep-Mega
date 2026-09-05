/*
 =======================================================================================
 CHALLENGE: Reversal (10-strings)
 CHAPTER: Chapter10_Strings
 
 DESCRIPTION:
 * # Reversal
 *
 * This application allows the user to enter a tex. The application will then reverse the order of the characters and return the result to the user.
 *
 * Implement the method `Reverse(string text)` in the class `StringReverser` so it returns the given string with the characters reversed.
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter10_Strings.Reversal.UnitTestStringReverser
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter10_Strings.Reversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Super Duper String Reverser");
            Console.Write("Please enter a text to reverse: ");
            string text = Console.ReadLine();

            StringReverser reverser = new StringReverser();

            Console.WriteLine($"\n{text}\n\nreversed:\n{reverser.Reverse(text)}");
        }
    }
}
