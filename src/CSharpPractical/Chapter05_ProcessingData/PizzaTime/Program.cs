/*
 =======================================================================================
 CHALLENGE: PizzaTime (05-processing-data)
 CHAPTER: Chapter05_ProcessingData
 
 DESCRIPTION:
 * # Pizza Time
 *
 * This little app lets us divide slices of pizza among people. Everyone gets his/her fair share.
 *
 * Two methods need to implemented inside of the file `PizzaTime\PizzaDivider.cs`:
 *
 * * `HowManySlicesPerPerson()`: Should calculate how many slices everyone gets. Fairly divided.
 * * `HowManySlicesLeft()`: Determines how many slices are left after everyone gets his/her fair share.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter05_ProcessingData.PizzaTime.UnitTestPizzaDivider
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter05_ProcessingData.PizzaTime
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaDivider pizzaDivider = new PizzaDivider();
            pizzaDivider.PrintToTerminal();
        }
    }
}
