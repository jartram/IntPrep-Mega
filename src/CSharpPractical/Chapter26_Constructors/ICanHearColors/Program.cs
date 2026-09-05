/*
 =======================================================================================
 CHALLENGE: ICanHearColors (26-constructors)
 CHAPTER: Chapter26_Constructors
 
 DESCRIPTION:
 * # I Can Hear Colors
 *
 * This project contains a basic `Color` class from a student that is learning C#. However the student did not have any knowledge of constructors and properties yet.
 *
 * A color consists of three components: red, green and blue. Each component can have a value between `0` and `255`. The `Color` class has some setters and getters provided that allow all three components (red, green and blue) to be set and retrieved.
 *
 * It's time to refactor this class a bit. One thing to keep in mind is that the guards provided in the setters should not be lost. However, this is where the unit tests have your back.
 *
 * * Start by replacing the getters and setters with properties for all three components (red, green and blue). Make sure to refactor the `Main` application to take this into account.
 * * Supply a default constructor that takes no arguments. Set all properties to `0` in this case.
 * * Supply a constructor that takes all three values (`red`, `green` and `blue`).
 * * Refactor `ToString()` so it keeps working as intended.
 * * Now replace the code in `Main` where the constructors can be used.
 *
 * ## Expected Output
 *
 * ```text
 * This application show how to use the color class
 *
 * Start by creating a new instance of Color: Red: 0 | Green: 0 | Blue: 0
 *
 * To change the color components we need to call the properties.
 * For example a nice green: Red: 0 | Green: 85 | Blue: 0
 * Or a very cute pink color Red: 128 | Green: 0 | Blue: 128
 *
 * We can also create a new instance and immediately initialize the color components.
 * For example: Red: 23 | Green: 5 | Blue: 34
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter26_Constructors.ICanHearColors.UnitTestColor
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter26_Constructors.ICanHearColors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This application show how to use the color class");

            Console.Write("Start by creating a new instance of Color: ");
            Color myFavoriteColor = new Color();
            Console.WriteLine(myFavoriteColor + "\n");

            Console.WriteLine("To change the color components we need to call the setters.");

            myFavoriteColor.SetGreen(85);
            Console.WriteLine("For example a nice green: " + myFavoriteColor);

            myFavoriteColor.SetRed(128);
            myFavoriteColor.SetGreen(0);
            myFavoriteColor.SetBlue(128);
            Console.WriteLine("Or a very cute pink color " + myFavoriteColor);
        }
    }
}
