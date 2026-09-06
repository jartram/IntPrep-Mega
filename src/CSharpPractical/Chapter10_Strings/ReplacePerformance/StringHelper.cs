/*
 =======================================================================================
 CHALLENGE: ReplacePerformance (10-strings)
 CHAPTER: Chapter10_Strings
 
 DESCRIPTION:
 * # Replace Performance
 *
 * This application allows replacicing substrings inside of other strings.
 *
 * You can for example replace the word `hello` in the sentence `hello from all and hello to all` to `bye` resulting in `bye from all and bye to all`.
 *
 * The app needs two implementations for this functionality. One using the build in library method `Replace` and one using your own construct. You can use other methods from the library such as `Substring()` and `IndexOf()` or you can only use conditional and loop constructs.
 *
 * The replacement should be case-sensitive. In other words `Hello` and `hello` are NOT the same.
 *
 * Make sure to check the *TODO* list in the Visual Studio project.
 *
 * ## Expected Output
 *
 * ```text
 * Welcome to ReplacePerformance
 *
 * Please enter a sentence to start with:
 * pogamming becomes fun once you know and understand the basics of the pogamming language
 *
 * Now please enter a word to search for: pogamming
 * Now please enter a word to replace it with: programming
 *
 * The result is:
 * Library (took 1568 ticks): programming becomes fun once you know and understand the basics of the programming language
 * Own (took 4076 ticks): programming becomes fun once you know and understand the basics of the programming language
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter10_Strings.ReplacePerformance.UnitTestStringHelper
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter10_Strings.ReplacePerformance
{
    public class StringHelper
    {
        public string ReplaceUsingLibrary(string text, string word, string replacement)
        {
            string alteredText = "";

            // TODO Use the string Replace method to replace all the occurences of word
            // with replacement inside of the string text;

            return alteredText;
        }
        
        public string ReplaceUsingOwnImplementation(string text, string word, string replacement)
        {
            string alteredText = "";

            // TODO Do the same as the other method but don't use the Replace method.
            // Build your own implementation.

            return alteredText;
        }
    }
}
