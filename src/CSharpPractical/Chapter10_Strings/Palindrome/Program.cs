/*
 =======================================================================================
 CHALLENGE: Palindrome (10-strings)
 CHAPTER: Chapter10_Strings
 
 DESCRIPTION:
 * # Palindrome
 *
 * A palindrome is a word, number or phrase of characters which reads the same backward as forward, such as `radar` or `madam` or `racecar` or the number `10801`.
 *
 * Implement the method `IsPalindrome(string word)` in the class `Palindrome` so it returns a boolean value indicating if the string is a palindrome or not.
 *
 * Make sure to convert the word to lowercase before starting your check. You should also apply the `Trim()` method to remove all whitespace before and after the word.
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter10_Strings.Palindrome.UnitTestPalindromeChecker
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter10_Strings.Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Palindrome");
            Console.Write("Please enter a word to check: ");
            string word = Console.ReadLine();

            PalindromeChecker checker = new PalindromeChecker();
            bool isPalindrome = checker.IsPalindrome(word);

            Console.WriteLine($"\n{word} is{(isPalindrome ? "" : " not")} a palindrome");
        }
    }
}
