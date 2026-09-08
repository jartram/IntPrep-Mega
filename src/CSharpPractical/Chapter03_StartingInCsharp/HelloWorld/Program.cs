/*
 =======================================================================================
 CHALLENGE: HelloWorld (03-starting-in-csharp)
 CHAPTER: Chapter03_StartingInCsharp
 
 DESCRIPTION:
 * # Hello World
 *
 * Open the C# project in this directory and edit the code so it outputs `Hello World` to the terminal.
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter03_StartingInCsharp.HelloWorldTest
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter03_StartingInCsharp.HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}
