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
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter08_MakingDecisions.LedSeriesResistor.UnitTestsResistorCalculator
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter08_MakingDecisions.LedSeriesResistor
{
    public class ResistorCalculator
    {
        double supplyVoltage = 0;
        double ledVoltage = 0;
        double current = 0;

        public double CalculateSeriesResistor()
        {
            double resistance = 0;

            // TODO Determine the resistance value for the series resistor of the LED
            // Warning, set the value to -1 if the ledVoltage is bigger than the supplyVoltage
            // or if the current is 0 or negative.
            
            return resistance;
        }

        public double SupplyVoltage { get { return supplyVoltage; } set { supplyVoltage = value; } }
        public double LedVoltage { get { return ledVoltage; } set { ledVoltage = value; } }
        public double Current { get { return current; } set { current = value; } }
    }
}
