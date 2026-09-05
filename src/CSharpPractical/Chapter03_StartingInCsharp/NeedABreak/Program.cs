/*
 =======================================================================================
 CHALLENGE: NeedABreak (03-starting-in-csharp)
 CHAPTER: Chapter03_StartingInCsharp
 
 DESCRIPTION:
 * # Need a Break
 *
 * The application has two small syntax errors. Find them and fix them.
 *
 * The application should output the following text to the terminal if you fixed the errors:
 *
 * ```text
 * One programmer said to another:
 * I need a </br>
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter03_StartingInCsharp.NeedABreakTest
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter03_StartingInCsharp.NeedABreak
{
    public class Program
    {
        public static string[] GetLines()
        {
            return new string[] { "One programmer said to another:", "I need a </br>" };
        }

        public static void Main(string[] args)
        {
            foreach (var line in GetLines())
            {
                Console.WriteLine(line);
            }
        }
    }
}
