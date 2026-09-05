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
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter10_Strings.WordsEverywhere.UnitTestWordCounter
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter10_Strings.WordsEverywhere
{
    public class WordCounter
    {
        public int CountWords(string text)
        {
            int numberOfWords = 0;

            // TODO Count the number of words in the text

            // Please dont change the code below (automatic unit tests)
            return numberOfWords;
        }
    }
}
