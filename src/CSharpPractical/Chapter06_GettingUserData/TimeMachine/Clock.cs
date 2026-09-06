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
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter06_GettingUserData.TimeMachine.UnitTestClock
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter06_GettingUserData.TimeMachine
{
    public class Clock
    {
        int hours = DateTime.Now.Hour;
        int minutes = DateTime.Now.Minute;

        public void AddHours(int delta)
        {
            // TODO: Add delta to hours
            // Keep in mind that hours should stay in range of [0, 23]
        }

        public void AddMinutes(int delta)
        {
            // TODO: Add delta to minutes
            // Keep in mind that minutes should stay in range of [0, 59]
            // Don't forget to add to hours when it overflows
        }

        public void PrintToTerminal()
        {
            Console.WriteLine($"Time: {hours.ToString("D2")}:{minutes.ToString("D2")}");
        }

        public int Hours { get { return hours; } set { hours = value; } }
        public int Minutes { get { return minutes; } set { minutes = value; } }
    }
}
