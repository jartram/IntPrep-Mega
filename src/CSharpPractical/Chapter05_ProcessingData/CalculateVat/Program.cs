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
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter05_ProcessingData.CalculateVat.UnitTestInvoice
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter05_ProcessingData.CalculateVat
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();
            invoice.PrintToTerminal();
        }
    }
}
