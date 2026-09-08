/*
 =======================================================================================
 CHALLENGE: DevelopedBy (03-starting-in-csharp)
 CHAPTER: Chapter03_StartingInCsharp
 
 DESCRIPTION:
 * # Developed By
 *
 * Modify the application so it prints out a welcome message to the user. It should also print your name as shown below.
 *
 * Example output:
 *
 * ```text
 * Hello and welcome to my Hello World in C#.
 * This application was developed by Nico De Witte.
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter03_StartingInCsharp.DevelopedByTest
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter03_StartingInCsharp.DevelopedBy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Write your implementation here
            // TODO: Output welcome message and your name
            Console.WriteLine("Hello and welcome to my Hello World in C#.");
            Console.WriteLine("This application was developed by Nico De Witte.");
        }   
    }
}
