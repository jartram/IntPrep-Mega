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

namespace CSharpPractical.Chapter04_StoringData.MarcoPolo
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalInformation info = new PersonalInformation();
            info.FullName();
            info.Age();
            info.EyeColor();
        }
    }
}
