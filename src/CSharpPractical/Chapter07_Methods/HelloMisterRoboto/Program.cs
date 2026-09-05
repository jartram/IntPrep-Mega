/*
 =======================================================================================
 CHALLENGE: HelloMisterRoboto (07-methods)
 CHAPTER: Chapter07_Methods
 
 DESCRIPTION:
 * # Hello Mister Roboto
 *
 * Hello Mister Roboto is the start of Bot in C#. It is a project created by a former student but it actually never really did anything. To encourage students to continue the project the application should at least output a welcome message to the user.
 *
 * First create a method `GreetTheUser()` that outputs the following message to the terminal:
 *
 * ```text
 * Hello, I am Mister Roboto.
 * I am the next-gen chat-bot created by VIVES students.
 * ```
 *
 * Call the method from the main application so the message is outputted if the application runs.
 *
 * Expected Output:
 *
 * ```text
 * Hello, I am Mister Roboto.
 * I am the next-gen chat-bot created by VIVES students.
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter07_Methods
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter07_Methods.HelloMisterRoboto
{
    class Program
    {
        internal static void GreetTheUser()
        {
            Console.WriteLine("Hello, I am Mister Roboto.");
            Console.WriteLine("I am the next-gen chat-bot created by VIVES students.");
        }

        static void Main(string[] args)
        {
            GreetTheUser();
        }
    }
}
