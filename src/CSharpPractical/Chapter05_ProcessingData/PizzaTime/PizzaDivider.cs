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
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter05_ProcessingData.PizzaTime.UnitTestPizzaDivider
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter05_ProcessingData.PizzaTime
{
    public class PizzaDivider
    {
        int numberOfPeople = 6;
        int slicesOfPizza = 13;

        public int HowManySlicesPerPerson()
        {
            // TODO Determine how many slices of pizza a person can have (same for everyone)
            int slicesPerPerson = 0;

            // Please dont change the code below (automatic unit tests)
            return slicesPerPerson;
        }

        public int HowManySlicesLeft()
        {
            // TODO Determine number of slices left if everyone gets his/her fair chance
            int numberOfSlicesLeft = 0;

            // Please dont change the code below (automatic unit tests)
            return numberOfSlicesLeft;
        }

        public void PrintToTerminal()
        {
            Console.WriteLine("There are " + numberOfPeople + " people eating pizza.");
            Console.WriteLine("There are " + slicesOfPizza + " slices of pizza.");
            Console.WriteLine("We give everyone " + HowManySlicesPerPerson() + " slices of pizza.");
            Console.WriteLine("In the end we will have " + HowManySlicesLeft() + " slices left in the end.");
        }
    }
}
