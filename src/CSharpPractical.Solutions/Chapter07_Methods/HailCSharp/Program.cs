/*
 =======================================================================================
 CHALLENGE: HailCSharp (07-methods)
 CHAPTER: Chapter07_Methods
 
 DESCRIPTION:
 * # Hail C Sharp
 *
 * It's time to tell C# what we think about it. I have prepared a method `HailCSharp` that outputs a statement about C# to the terminal.
 *
 * Call the method in `Main` so the following output is generated when the application runs:
 *
 * ```text
 * C# is good starter language as its syntax is easy to learn.
 * Microsoft first time use the name C# in 1988.
 * C# can also be used to develop games.
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter07_Methods.HailCSharpTest
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter07_Methods.HailCSharp
{
    class Program
    {
        internal static void HailCSharp()
        {
            Console.WriteLine("C# is good starter language as its syntax is easy to learn.");
            Console.WriteLine("Microsoft used the name C# for the first time in 1988.");
            Console.WriteLine("C# can also be used to develop games.");
        }

        static void Main(string[] args)
        {
            HailCSharp();
            // TODO Call the HailCSharp method here so it outputs
            // its statements to the terminal.

        }
    }
}
