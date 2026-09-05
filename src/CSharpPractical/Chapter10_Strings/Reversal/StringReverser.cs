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
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter10_Strings.Reversal.UnitTestStringReverser
 =======================================================================================
*/

using System;
using System.Linq;

namespace CSharpPractical.Chapter10_Strings.Reversal
{
    public class StringReverser
    {
        public string Reverse(string text)
        {
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
