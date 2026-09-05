/*
 =======================================================================================
 CHALLENGE: The_metric_system (06-getting-user-data)
 CHAPTER: Chapter06_GettingUserData
 
 DESCRIPTION:
 * Convert between metric units and imperial units.
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter06_GettingUserData.The_metric_system
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter06_GettingUserData.The_metric_system
{
    public class Program
    {
        public static double CentimetersToInches(double cm) => cm / 2.54;
        public static double InchesToCentimeters(double inches) => inches * 2.54;

        public static void Main(string[] args)
        {
            Console.WriteLine("Metric System Converter");
        }
    }
}
