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
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter10_Strings.Palindrome.UnitTestPalindromeChecker
 =======================================================================================
*/

using System;
using System.Linq;

namespace CSharpPractical.Chapter10_Strings.Palindrome
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;
            string trimmed = text.Trim();
            if (string.IsNullOrEmpty(trimmed)) return false;
            string lower = trimmed.ToLower();
            string rev = new string(lower.Reverse().ToArray());
            return lower == rev;
        }
    }
}
