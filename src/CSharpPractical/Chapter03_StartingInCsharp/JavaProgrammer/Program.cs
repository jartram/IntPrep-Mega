/*
 =======================================================================================
 CHALLENGE: JavaProgrammer (03-starting-in-csharp)
 CHAPTER: Chapter03_StartingInCsharp
 
 DESCRIPTION:
 * # Java Programmers
 *
 * The problem with Java programmers is that they can't see sharp. This was an application developed by a Java programmer and he/she did not know the correct methods to output something to the terminal. Fix the code so the application output the following text:
 *
 * ```text
 * I switched from Java to C# and this is my app.
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter03_StartingInCsharp.JavaProgrammerTest
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter03_StartingInCsharp.JavaProgrammer
{
    public class Program
    {
        public static string GetMessage()
        {
            // TODO: Fix the Java mistake below and return "I switched from Java to C# and this is my app."
            // System.out.println("I switched from Java to C# and this is my app.");
            throw new NotImplementedException();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(GetMessage());
        }
    }
}
