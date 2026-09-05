/*
 =======================================================================================
 CHALLENGE: ParenthesesChecker (10-strings)
 CHAPTER: Chapter10_Strings
 
 DESCRIPTION:
 * # Parentheses Checker
 *
 * This application is a smaller part of a compiler. It needs to implement the functionality that check the parentheses `()` of user code and determine if the opening parentheses are matched with closing parentheses.
 *
 * Some examples:
 *
 * | Code Example | Valid? |
 * | ---- | :----: |
 * | `Console.WriteLine("Hello");` | `true` |
 * | `boolean valid = ((A > B) || (C < D);` | `false` |
 * | `Console.WriteLine)(("Hello World");` | `false` |
 *
 * The simplest approach is to just count the number of opening and closing parentheses and check if they are the same. Problem then is that you are not really checking if the parentheses match. That is why the third example above is invalid.
 *
 * A better approach is to keep a single counter and do the following:
 *
 * * increment the counter when an opening parentheses is discovered
 * * decrement the counter when a closing parentheses is encountered.
 *
 * The code is invalid if either of the following happens:
 *
 * * the counter ever becomes negative
 * * the counter is not `0` in the end
 *
 * Implement the method `HasMatchingParentheses(string code)` in the class `CodeLinter` so it returns a boolean value indicating if the code has valid matching parentheses.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter10_Strings.ParenthesesChecker.UnitTestCodeLinter
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter10_Strings.ParenthesesChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# Parentheses Checker");
            Console.WriteLine("Please enter a single line of code below to check:");
            string code = Console.ReadLine();

            CodeLinter linter = new CodeLinter();
            if (linter.HasMatchingParentheses(code))
            {
                Console.WriteLine($"\nThe code snippet is valid.");
            }
            else
            {
                Console.WriteLine($"\nThe code snippet contains unmatched parentheses.");
            }
        }
    }
}
