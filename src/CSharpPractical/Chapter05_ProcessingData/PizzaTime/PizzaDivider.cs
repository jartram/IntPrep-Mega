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

using System;

namespace CSharpPractical.Chapter05_ProcessingData.PizzaTime
{
    public class PizzaDivider
    {
        private int slicesOfPizza = 23;
        private int numberOfPeople = 4;

        public int HowManySlicesPerPerson()
        {
            return slicesOfPizza / numberOfPeople;
        }

        public int HowManySlicesLeft()
        {
            return slicesOfPizza % numberOfPeople;
        }
            public void PrintToTerminal() { }
}
}
