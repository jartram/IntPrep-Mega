/*
 =======================================================================================
 CHALLENGE: TimeMachine (06-getting-user-data)
 CHAPTER: Chapter06_GettingUserData
 
 DESCRIPTION:
 * # Time Machine
 *
 * The year is 2014. You just turned 14 years old but you are already a wizz-kid with computers. While programming in C# you discovered some hidden classes inside the system that allowed you to manipulate time (sorry, no space).
 *
 * You developed a class called `Clock` that allows you to jump forward in time. All that remains is to implement the methods that allow you to jump a number of hours (`AddHours()`) and a number of minutes (`AddMinutes()`) forward.
 *
 * Last but not least, you want to share your app with the world. To do this you will need to make it more user friendly. Change the `Main()` application a bit so the user can enter the number of minutes and hours he/she wants to jump forward.
 *
 * Example Output:
 *
 * ```text
 * Welcome to your personal time machine.
 *
 * The current time is
 * Time: 21:11
 *
 * How much minutes would you like to jump forward? 182
 * How much hours would you like to jump forward? 12
 *
 * Congratz. You jumped forward in time to
 * Time: 12:13
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter06_GettingUserData.TimeMachine.UnitTestClock
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter06_GettingUserData.TimeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();

            Console.WriteLine("Welcome to your personal time machine.\n");

            Console.WriteLine("The current time is");
            clock.PrintToTerminal();

            // TODO: Request number of minutes to add from the user
            int minutes = 0;

            // TODO: Request number of hours to add from the user
            int hours = 0;

            // TODO: Add the actual values to the current clock time
            // Call the AddMinutes() method
            // Call the AddHours() method

            Console.WriteLine("\nCongratz. You jumped forward in time to");
            clock.PrintToTerminal();
        }
    }
}
