/*
 =======================================================================================
 CHALLENGE: DriftingYears (08-making-decisions)
 CHAPTER: Chapter08_MakingDecisions
 
 DESCRIPTION:
 * # Drifting Years
 *
 * A leap year is a calendar year containing an additional day added to keep the calendar year synchronized with the astronomical or seasonal year. Because seasons and astronomical events do not repeat in a whole number of days, calendars that have the same number of days in each year drift over time with respect to the event that the year is supposed to track. By inserting an additional day or month into the year, the drift can be corrected. A year that is not a leap year is called a common year.
 *
 * In the Gregorian calendar, each leap year has 366 days instead of 365, by extending February to 29 days rather than the common 28.
 *
 * Every year that is exactly divisible by four is a leap year, except for years that are exactly divisible by 100, but these centurial years are leap years if they are exactly divisible by 400.
 *
 * Request a year from the user and output to the user if it is a common year or a leap year. Do this inside of `Main()`.
 *
 * Also implement the method `IsLeapYear()` inside the class `LeapYearChecker`.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter08_MakingDecisions.DriftingYears.UnitTestLeapYearChecker
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter08_MakingDecisions.DriftingYears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the latest and greatest leap year checker.\n");

            // TODO: Request year from the user
            int year = 0;

            // Creating a leap year checker object
            LeapYearChecker leapChecker = new LeapYearChecker();

            // Checking if year is a leap year
            bool isUserYearLeapYear = leapChecker.IsLeapYear(year);

            // TODO: Output message to the user
            // Build if - else and use isUserYearLeapYear as condition

            // Done
            Console.WriteLine("\nThank for using our app.");
        }
    }
}
