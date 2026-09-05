/*
 =======================================================================================
 CHALLENGE: CsharpLand (04-storing-data)
 CHAPTER: Chapter04_StoringData
 
 DESCRIPTION:
 * # RollerCoaster
 *
 * The C# RollerCoaster app is an app that informs the passengers of the minimum required height to rider the rollercoaster. However, a small bug has slipped into the code and the programmer did not initialize the variable correctly that stores the minimum height.
 *
 * Please correct the mistake and set the minimum required height to `1m and 30cm`.
 *
 * Change the code in the method `ShowMinimumHeight` in the file `CSharpLand\RollerCoaster.cs`.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter04_StoringData.CsharpLand.RollerCoasterTest
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter04_StoringData.CsharpLand
{
    class Program
    {
        static void Main(string[] args)
        {
            RollerCoaster coaster = new RollerCoaster();
            coaster.ShowMinimumHeight();
        }
    }
}
