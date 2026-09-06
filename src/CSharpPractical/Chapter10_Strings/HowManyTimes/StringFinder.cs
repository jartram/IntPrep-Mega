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
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter10_Strings.HowManyTimes.UnitTestStringFinder
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter10_Strings.HowManyTimes
{
    public class StringFinder
    {
        public int SearchAndCount(string text, string word)
        {
            int numberOfOccurrences = 0;

            // TODO Count the number of times the word occurs in the text

            // Please dont change the code below (automatic unit tests)
            return numberOfOccurrences;
        }
    }
}
