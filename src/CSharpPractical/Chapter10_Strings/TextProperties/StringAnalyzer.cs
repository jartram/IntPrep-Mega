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
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter10_Strings.TextProperties.UnitTestStringAnalyzer
 =======================================================================================
*/

using System;
using System.Linq;

namespace CSharpPractical.Chapter10_Strings.TextProperties
{
    public class StringAnalyzer
    {
        public int NumberOfVowels(string text) => text.Count(c => "aeiouAEIOU".Contains(c));
        public int NumberOfConsonants(string text) => text.Count(c => char.IsLetter(c) && !"aeiouAEIOU".Contains(c));
        public int NumberOfDigits(string text) => text.Count(char.IsDigit);
        public int NumberOfUppercaseLetters(string text) => text.Count(char.IsUpper);
        public int NumberOfLowercaseLetters(string text) => text.Count(char.IsLower);
        public int NumberOfWhitespaceCharacters(string text) => text.Count(char.IsWhiteSpace);
    }
}
