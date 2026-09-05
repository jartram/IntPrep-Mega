/*
 =======================================================================================
 CHALLENGE: MarcoPolo (04-storing-data)
 CHAPTER: Chapter04_StoringData
 
 DESCRIPTION:
 * # Marco Polo
 *
 * This application tries to display some personal information about a guy named "Marco Polo". However, some parts of the code are not finished yet.
 *
 * There are three methods in the file `MarcoPolo\PersonalInformation.cs` that need some extra work:
 *
 * * `FullName`: Concatenate `firstname` and `lastname` and assign the result to the variable `fullname`
 * * `Age`: Initialize `age` to 19
 * * `EyeColor`: Set the color of my eyes to blue
 *
 * Expected output:
 *
 * ```text
 * Hello, I am Marco Polo
 * I am 19 years of age.
 * I have fancy blue colored eyes.
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter04_StoringData.MarcoPolo.UnitTestPersonalInformation
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter04_StoringData.MarcoPolo
{
    public class PersonalInformation
    {
        public string FullName()
        {
            string firstname = "Marco";
            string lastname = "Polo";

            // TODO: Concatenate firstname and lastname and assign to fullname
            string fullname = "";

            Console.WriteLine("Hello, I am " + fullname);

            // Please dont change the code below (automatic unit tests)
            return fullname;
        }

        public int Age()
        {
            // TODO: Initialize age to 19
            int age = 0;

            Console.WriteLine("I am " + age + " years of age.");

            // Please dont change the code below (automatic unit tests)
            return age;
        }

        public string EyeColor()
        {
            // TODO: Set the color of my eyes to blue
            string colorOfMyEyes = "grey";

            Console.WriteLine("I have fancy " + colorOfMyEyes + " colored eyes.");

            // Please dont change the code below (automatic unit tests)
            return colorOfMyEyes;
        }
    }
}
