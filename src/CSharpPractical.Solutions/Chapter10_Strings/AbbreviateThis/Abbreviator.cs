/*
 =======================================================================================
 CHALLENGE: AbbreviateThis (10-strings)
 CHAPTER: Chapter10_Strings
 
 DESCRIPTION:
 * # Abbreviate This
 *
 * Abbreviate This is an application that can transform a `string` containing a number of words into an abbreviation of those words. It can for example transform "rolling on floor laughing" into "ROFL".
 *
 * The class `Abbreviator` should implement the transformation from text to abbreviation. This is your job.
 *
 * Your task (also see `View => Task List` in Visual Studio):
 *
 * * Implement the method `Abbreviate` in the class `Abbreviator` so it converts the string in `text` to an abbreviation (first letter of each word)
 * * Make sure that the letters in the end-result are all upper-case.
 * * If the variable `text` references an empty `string`, than make sure to return an empty string as well.
 *
 * ## Expected output
 *
 * ```text
 * Welcome to Abbreviate This ...
 * LOL means Laughing Out Loud
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter10_Strings.AbbreviateThis.UnitTestAbbreviator
 =======================================================================================
*/

using System;
using System.Linq;

namespace CSharpPractical.Chapter10_Strings.AbbreviateThis
{
    public class Abbreviator
    {
        public string Abbreviate(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return "";
            var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Concat(words.Select(w => char.ToUpper(w[0])));
        }
    }
}
