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
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter10_Strings.TextProperties
{
    public class StringAnalyzer
    {
        public int NumberOfVowels(string text)
        {
            int numberOfVowels = 0;

            // TODO Count the number of vowels inside of text

            return numberOfVowels;
        }

        public int NumberOfConsonants(string text)
        {
            int numberOfConsonants = 0;

            // TODO Count the number of consonants inside of text

            return numberOfConsonants;
        }

        public int NumberOfDigits(string text)
        {
            int numberOfDigits = 0;

            // TODO Count the number of digits inside of text

            return numberOfDigits;
        }

        public int NumberOfUppercaseLetters(string text)
        {
            int numberOfUppercaseLetters = 0;

            // TODO Count the number of upper case letters inside of text

            return numberOfUppercaseLetters;
        }

        public int NumberOfLowercaseLetters(string text)
        {
            int numberOfLowercaseLetters = 0;

            // TODO Count the number of lower case letters inside of text

            return numberOfLowercaseLetters;
        }

        public int NumberOfWhitespaceCharacters(string text)
        {
            int numberOfWhitespaceCharacters = 0;

            // TODO Count the number of whitespace characters inside of text

            return numberOfWhitespaceCharacters;
        }
    }
}
