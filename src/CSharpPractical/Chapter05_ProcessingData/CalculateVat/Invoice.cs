/*
 =======================================================================================
 CHALLENGE: CalculateVat (05-processing-data)
 CHAPTER: Chapter05_ProcessingData
 
 DESCRIPTION:
 * # Calculate VAT
 *
 * When buying a product in the store you always need to pay VAT (taxes). Take for example a pair of shoes that costs 100eur net, you actually pay 121eur. On top of your net price, comes 21% VAT.
 *
 * This application should allow you to calculate the VAT you need to pay. Implement the method `GetVAT` inside the file `CalculateVAT\Invoice.vs`.
 *
 * Example output:
 *
 * ```text
 * For a net value of 250euro
 * you need to pay 21% VAT.
 * So the total price you pay is
 * 250euro + 52.5euro = 302.5euro
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter05_ProcessingData.CalculateVat.UnitTestInvoice
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter05_ProcessingData.CalculateVat
{
    public class Invoice
    {
        double netPrice = 250.0;
        double vatPercentage = 21;

        public double GetVAT()
        {
            // TODO: Calculate the vat percentage of the net value
            double vat = 0;

            // Please dont change the code below (automatic unit tests)
            return vat;
        }

        public double GetTotal()
        {
            return netPrice + GetVAT();
        }

        public void PrintToTerminal()
        {
            Console.WriteLine("For a net value of " + netPrice + "euro");
            Console.WriteLine("you need to pay " + vatPercentage + "% VAT.");
            Console.WriteLine("So the total price you pay is");
            Console.WriteLine(netPrice + "euro " + "+ " + GetVAT() + "euro = " + GetTotal() + "euro");
        }
    }
}
