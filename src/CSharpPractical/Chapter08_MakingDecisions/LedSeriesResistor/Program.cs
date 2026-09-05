/*
 =======================================================================================
 CHALLENGE: LedSeriesResistor (08-making-decisions)
 CHAPTER: Chapter08_MakingDecisions
 
 DESCRIPTION:
 * # LED Series Resistor
 *
 * An LED (Light Emiting Diode) is an electronic component that emits light if current flows through it. LEDs show a voltage drop, depending on the type and color. It is required to provide a resistor for each LED.
 *
 * Before the resistance can be calculated, the following data is required:
 *
 * 1. The voltage over the LED
 * 2. The required current for the LED
 * 3. The supply voltage that will be used
 *
 * Then the series resistor can be calculated using the formula:
 *
 *
 * Your task (also see `View => Task List` in Visual Studio):
 *
 * * Implement the method `CalculateSeriesResistor()` in the class `ResistorCalculator` so it determines the resistance.
 *
 * ## Expected output
 *
 * ```text
 * Welcome to the LED series resistor calculator
 * Your place to calculate your series resistors for LEDs.
 * ----------------------------------------------------
 *
 * Please enter your supply voltage [V]: 9
 * Please enter the voltage drop over the LED [V]: 2
 * What current do you want to drive through the LED [A]: 0.01
 *
 * You will need a resistor of 700 Ohm
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter08_MakingDecisions.LedSeriesResistor.UnitTestsResistorCalculator
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter08_MakingDecisions.LedSeriesResistor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LED series resistor calculator");
            Console.WriteLine("Your place to calculate your series resistors for LEDs.");
            Console.WriteLine("----------------------------------------------------");

            // Create object of ResistorCalculator
            ResistorCalculator resistorCalculator = new ResistorCalculator();

            // Request the supply voltage of the user
            Console.Write("\nPlease enter your supply voltage [V]: ");
            resistorCalculator.SupplyVoltage = Convert.ToDouble(Console.ReadLine());

            // Request the voltage over the LED from the user
            Console.Write("Please enter the voltage drop over the LED [V]: ");
            resistorCalculator.LedVoltage = Convert.ToDouble(Console.ReadLine());

            // Request the current through the LED from the user
            Console.Write("What current do you want to drive through the LED [A]: ");
            resistorCalculator.Current = Convert.ToDouble(Console.ReadLine());

            // Determine the series resistor using the supplied information from the user
            double seriesResistor = resistorCalculator.CalculateSeriesResistor();

            // Output the result
            Console.WriteLine($"\nYou will need a resistor of {seriesResistor} Ohm");
        }
    }
}
