/*
 =======================================================================================
 CHALLENGE: BasicSyntaxError (03-starting-in-csharp)
 CHAPTER: Chapter03_StartingInCsharp
 
 DESCRIPTION:
 * # Basic Syntax Error
 *
 * The application has a small syntax error. Find it and fix it.
 *
 * The application should output the following text to the terminal if you fixed the error:
 *
 * ```text
 * Nice, you just fixed the application.
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter03_StartingInCsharp.BasicSyntaxErrorTest
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter03_StartingInCsharp.BasicSyntaxError
{
    public class Program
    {
        public static string GetMessage()
        {
            return "Nice, you just fixed the application.";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(GetMessage());
        }
    }
}
