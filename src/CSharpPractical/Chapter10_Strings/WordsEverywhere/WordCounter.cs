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

using System;

namespace CSharpPractical.Chapter10_Strings.WordsEverywhere
{
    public class WordCounter
    {
        public int CountWords(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return 0;
            return text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
